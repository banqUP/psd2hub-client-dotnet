using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.PaymentForm
{
    // internal
    public class SubmittedFormLinks
    {
        [JsonProperty(PropertyName = "payment", Required = Required.Always)]
        public string Payment { get; set; }

        [JsonProperty(PropertyName = "paymentStatus", Required = Required.Always)]
        public string PaymentStatus { get; set; }
        
        [JsonProperty(PropertyName = "cancelPayment")]
        public string Cancel { get; set; }
    }
}
