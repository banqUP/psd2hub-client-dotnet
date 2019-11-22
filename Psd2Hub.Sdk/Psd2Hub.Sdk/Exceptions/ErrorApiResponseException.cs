namespace Psd2Hub.Sdk.Exceptions
{
    public class ErrorApiResponseException : ApiException
    {
        public ErrorApiResponseException(ApiModels.Error error)
            : base(error.DisplayMessage)
        {
            Details = error.Details;
        }

        public object Details { get; }
    }
}
