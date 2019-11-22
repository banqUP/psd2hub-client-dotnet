using Psd2Hub.Sdk.RestClient;

namespace Psd2Hub.Sdk.Extensions
{
    internal static class SimpleInjectorContainerExtensions
    {
        public static void RegisterApiClientDependencies(this SimpleInjector.Container container)
        {
            container.Register<IRestClient, RestClient.RestClient>();
            container.Register<IResponseDeserializer, ResponseDeserializer>();
            container.Register<RestSharp.IRestClient>(() => new RestSharp.RestClient());
        }
    }
}
