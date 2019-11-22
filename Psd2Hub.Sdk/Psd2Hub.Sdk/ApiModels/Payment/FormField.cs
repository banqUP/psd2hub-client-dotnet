using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    internal class FormField
    {
        [JsonProperty(PropertyName = "label", Required = Required.Always)]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public string Type { get; set; }
    }
}
