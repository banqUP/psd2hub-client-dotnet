using Newtonsoft.Json;
using System;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    internal class Payment
    {
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "status", Required = Required.Always)]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "_links", Required = Required.Always)]
        public PaymentLinks Links { get; set; }
    }
}
