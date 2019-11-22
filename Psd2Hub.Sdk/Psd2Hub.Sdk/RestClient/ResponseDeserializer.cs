using Newtonsoft.Json;

namespace Psd2Hub.Sdk.RestClient
{
    internal class ResponseDeserializer : IResponseDeserializer
    {
        public TResult Deserialize<TResult>(string value)
        {
            return JsonConvert.DeserializeObject<TResult>(value);
        }
    }
}
