using RestSharp;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.ApiClient
{
    // internal
    public class ApiClient : IApiClient
    {
        private readonly IResponseDeserializer _deserializer;
        private readonly IRestClient _restClient;

        public ApiClient(IResponseDeserializer deserializer, IRestClient restClient)
        {
            _deserializer = deserializer;
            _restClient = restClient;
        }

        public Task<TResponse> Execute<TResponse>(string resource, Method method)
        {
            return Execute<TResponse>(new RestRequest(resource, method));
        }

        public Task<TResponse> Execute<TResponse, TRequest>(string resource, Method method, TRequest body)
        {
            var request = new RestRequest(resource, method);
            if (body != null)
            {
                request.AddJsonBody(body);
            }

            return Execute<TResponse>(request);
        }

        public Task ExecuteNoContent(string resource, Method method)
        {
            return ExecuteNoContent(new RestRequest(resource, method));
        }

        private async Task<TResponse> Execute<TResponse>(RestRequest request)
        {
            var response = await _restClient.ExecuteTaskAsync(request);

            try
            {
                return _deserializer.Deserialize<TResponse>(response.Content);
            }
            catch
            {
                if (TryDeserializeToError(response.Content, out var error))
                {
                    throw new Exceptions.ErrorApiResponseException(error);
                }
                else
                {
                    throw;
                }
            }
        }

        private Task ExecuteNoContent(RestRequest request)
        {
            return _restClient.ExecuteTaskAsync(request);
        }

        private bool TryDeserializeToError(string responseContent, out ApiModels.Error error)
        {
            try
            {
                error = _deserializer.Deserialize<ApiModels.Error>(responseContent);
                return true;
            }
            catch
            {
                error = default;
                return false;
            }
        }
    }
}
