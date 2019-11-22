using System.Threading.Tasks;

namespace Psd2Hub.Sdk.RestClient
{
    internal interface IRestClient
    {
        Task<TResponse> Execute<TResponse>(string resource, RestSharp.Method method);
        Task<TResponse> Execute<TResponse, TRequest>(string resource, RestSharp.Method method, TRequest body);
        Task ExecuteNoContent(string resource, RestSharp.Method method);

        string Url { set; }
        string SubscriptionKey { set; }
    }
}
