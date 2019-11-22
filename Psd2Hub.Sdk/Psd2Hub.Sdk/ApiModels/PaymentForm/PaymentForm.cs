using Newtonsoft.Json;
using System.Collections.Generic;

namespace Psd2Hub.Sdk.ApiModels.PaymentForm
{
    // internal
    public class PaymentForm
    {
        [JsonProperty(PropertyName = "paymentType", Required = Required.Always)]
        public string PaymentType { get; set; }

        [JsonProperty(PropertyName = "fields", Required = Required.Always)]
        public Dictionary<string, Field> Fields { get; set; }

        [JsonProperty(PropertyName = "_links", Required = Required.Always)]
        public PaymentFormLinks Links { get; set; }
    }
}
