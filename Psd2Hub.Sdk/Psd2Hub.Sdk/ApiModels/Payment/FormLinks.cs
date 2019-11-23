using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    internal class FormLinks
    {
        [JsonProperty(PropertyName = "submitPayment", Required = Required.Always)]
        public string SubmitPayment { get; set; }
    }
}
