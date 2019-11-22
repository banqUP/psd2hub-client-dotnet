using Newtonsoft.Json;
using System;

namespace Psd2Hub.Sdk.ApiModels.PaymentForm
{
    // internal
    public class SubmittedForm
    {
        [JsonProperty(PropertyName = "paymentId", Required = Required.Always)]
        public Guid PaymentId { get; set; }

        [JsonProperty(PropertyName = "_links", Required = Required.Always)]
        public SubmittedFormLinks Links { get; set; }
    }
}
