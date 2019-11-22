using Newtonsoft.Json;
using System.Collections.Generic;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    internal class Form
    {
        [JsonProperty(PropertyName = "paymentType", Required = Required.Always)]
        public string PaymentType { get; set; }

        [JsonProperty(PropertyName = "fields", Required = Required.Always)]
        public Dictionary<string, FormField> Fields { get; set; }

        [JsonProperty(PropertyName = "_links", Required = Required.Always)]
        public FormLinks Links { get; set; }
    }
}
