using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.PaymentForm
{
    // internal
    public class PaymentFormLinks
    {
        [JsonProperty(PropertyName = "makePayment", Required = Required.Always)]
        public string MakePayment { get; set; }
    }
}
