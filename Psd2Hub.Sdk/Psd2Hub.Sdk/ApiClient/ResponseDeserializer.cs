using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiClient
{
    // internal
    public class ResponseDeserializer : IResponseDeserializer
    {
        public TResult Deserialize<TResult>(string value)
        {
            return JsonConvert.DeserializeObject<TResult>(value);
        }
    }
}
