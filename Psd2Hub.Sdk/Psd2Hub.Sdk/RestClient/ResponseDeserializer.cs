using Newtonsoft.Json;
using Psd2Hub.Sdk.Exceptions;

namespace Psd2Hub.Sdk.RestClient
{
    internal class ResponseDeserializer : IResponseDeserializer
    {
        public TResult Deserialize<TResult>(string value)
        {
            var result = JsonConvert.DeserializeObject<TResult>(value);
            if (result == null)
            {
                throw new ResponseDeserializationException(value, typeof(TResult));
            }

            return result;
        }
    }
}
