using System.Threading.Tasks;

namespace Psd2Hub.Sdk.RestClient
{
    internal static class RestClientExtensions
    {
        public static Task<TResponse> Get<TResponse>(this IRestClient restClient, string resource)
        {
            return restClient.Execute<TResponse>(resource, RestSharp.Method.GET);
        }

        public static Task<TResponse> Post<TResponse, TRequest>(this IRestClient restClient, string resource, TRequest body)
        {
            return restClient.Execute<TResponse, TRequest>(resource, RestSharp.Method.POST, body);
        }
    }
}
