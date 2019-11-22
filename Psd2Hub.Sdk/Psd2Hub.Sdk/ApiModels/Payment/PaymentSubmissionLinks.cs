using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    internal class PaymentSubmissionLinks
    {
        [JsonProperty(PropertyName = "sca", Required = Required.Always)]
        public string Sca { get; set; }

        [JsonProperty(PropertyName = "payment", Required = Required.Always)]
        public string Payment { get; set; }
    }
}
