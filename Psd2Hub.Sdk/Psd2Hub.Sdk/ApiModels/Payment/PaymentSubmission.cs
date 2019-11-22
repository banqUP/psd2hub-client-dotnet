using Newtonsoft.Json;
using System;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    internal class PaymentSubmission
    {
        [JsonProperty(PropertyName = "paymentId", Required = Required.Always)]
        public Guid PaymentId { get; set; }

        [JsonProperty(PropertyName = "_links", Required = Required.Always)]
        public PaymentSubmissionLinks Links { get; set; }
    }
}
