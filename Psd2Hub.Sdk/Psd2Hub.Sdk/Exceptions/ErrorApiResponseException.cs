using System.Collections;
using System.Collections.Generic;

namespace Psd2Hub.Sdk.Exceptions
{
    public class ErrorApiResponseException : ApiException
    {
        private readonly Dictionary<string, object> _data;

        internal ErrorApiResponseException(ApiModels.Error error)
            : base(error.DisplayMessage)
        {
            _data = new Dictionary<string, object> { { "details", error.Details } };
        }

        public override IDictionary Data => _data;
    }
}
