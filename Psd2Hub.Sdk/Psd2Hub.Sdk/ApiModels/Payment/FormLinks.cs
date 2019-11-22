using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    internal class FormLinks
    {
        [JsonProperty(PropertyName = "makePayment", Required = Required.Always)]
        public string MakePayment { get; set; }
    }
}
