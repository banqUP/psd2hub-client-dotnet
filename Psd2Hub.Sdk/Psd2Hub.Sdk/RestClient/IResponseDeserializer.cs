namespace Psd2Hub.Sdk.RestClient
{
    internal interface IResponseDeserializer
    {
        TResult Deserialize<TResult>(string value);
    }
}
