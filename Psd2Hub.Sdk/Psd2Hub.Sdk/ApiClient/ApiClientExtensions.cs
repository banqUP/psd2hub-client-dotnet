using System.Threading.Tasks;

namespace Psd2Hub.Sdk.ApiClient
{
    internal static class ApiClientExtensions
    {
        public static Task<TResponse> Get<TResponse>(this IApiClient apiClient, string resource)
        {
            return apiClient.Execute<TResponse>(resource, RestSharp.Method.GET);
        }

        public static Task<TResponse> Post<TResponse, TRequest>(this IApiClient apiClient, string resource, TRequest body)
        {
            return apiClient.Execute<TResponse, TRequest>(resource, RestSharp.Method.POST, body);
        }
    }
}
