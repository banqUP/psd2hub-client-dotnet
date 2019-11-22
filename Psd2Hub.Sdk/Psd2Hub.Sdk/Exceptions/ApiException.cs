using System;

namespace Psd2Hub.Sdk.Exceptions
{
    public abstract class ApiException : Exception
    {
        internal ApiException(string message) : base(message)
        {
        }

        internal ApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
