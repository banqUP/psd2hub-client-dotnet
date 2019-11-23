using Newtonsoft.Json;
using Psd2Hub.Sdk.Exceptions;
using System;

namespace Psd2Hub.Sdk.RestClient
{
    internal class ResponseDeserializer : IResponseDeserializer
    {
        public TResult Deserialize<TResult>(string value)
        {
            try
            {
                return JsonConvert.DeserializeObject<TResult>(value);
            }
            catch (Exception e)
            {
                throw new ResponseDeserializationException(value, typeof(TResult), e);
            }
        }
    }
}
