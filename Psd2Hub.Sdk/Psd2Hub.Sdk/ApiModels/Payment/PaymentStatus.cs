using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    // internal
    public class PaymentStatus
    {
        [JsonProperty(PropertyName = "status", Required = Required.Always)]
        public string Value { get; set; }
    }
}
