using Newtonsoft.Json;
using System.Collections.Generic;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    internal class FormField
    {
        [JsonProperty(PropertyName = "choices")]
        public Dictionary<string, string> Choices { get; set; }

        [JsonProperty(PropertyName = "required")]
        public bool Required { get; set; }

        [JsonProperty(PropertyName = "label", Required = Newtonsoft.Json.Required.Always)]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "type", Required = Newtonsoft.Json.Required.Always)]
        public string Type { get; set; }
    }
}
