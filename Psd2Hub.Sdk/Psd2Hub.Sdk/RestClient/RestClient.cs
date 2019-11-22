using RestSharp;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.RestClient
{
    internal class RestClient : IRestClient
    {
        private readonly IResponseDeserializer _deserializer;
        private readonly RestSharp.IRestClient _restClient;

        private string _url;

        public RestClient(IResponseDeserializer deserializer, RestSharp.IRestClient restClient)
        {
            _deserializer = deserializer;
            _restClient = restClient;
        }

        public string SubscriptionKey { private get; set; }
        public string Url 
        { 
            set 
            { 
                _url = value; 
                _restClient.BaseUrl = new System.Uri(value); 
            } 
        }

        public Task<TResponse> Execute<TResponse>(string resource, Method method)
        {
            return ExecuteAndDeserialize<TResponse>(new RestRequest(resource, method));
        }

        public Task<TResponse> Execute<TResponse, TRequest>(string resource, Method method, TRequest body)
        {
            var request = new RestRequest(resource, method);
            if (body != null)
            {
                request.AddJsonBody(body);
            }

            return ExecuteAndDeserialize<TResponse>(request);
        }

        public Task ExecuteNoContent(string resource, Method method)
        {
            return Execute(new RestRequest(resource, method));
        }

        private async Task<TResponse> ExecuteAndDeserialize<TResponse>(RestRequest request)
        {
            var response = await Execute(request);

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

        private Task<IRestResponse> Execute(RestRequest request)
        {
            if (_url == null)
            {
                throw new System.InvalidOperationException(
                    "Client base url has to be set before executing a request.");
            }
            if (SubscriptionKey == null)
            {
                throw new System.InvalidOperationException(
                    "Client subscription key has to be set before executing a request.");
            }

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
