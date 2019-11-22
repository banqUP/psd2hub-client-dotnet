namespace Psd2Hub.Sdk.ApiClient
{
    // internal
    public interface IResponseDeserializer
    {
        TResult Deserialize<TResult>(string value);
    }
}
