using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Psd2Hub.Sdk.Exceptions
{
    public class ResponseDeserializationException : ApiException
    {
        private readonly Dictionary<string, object> _data;
      
        public ResponseDeserializationException(string responseContent, Type destinationType) 
            : base($"Could not deserialize response into '{destinationType}' type.")
        {
            _data = new Dictionary<string, object>
            {
                { "responseContent", responseContent }
            };
        }

        public override IDictionary Data => _data;
    }
}
