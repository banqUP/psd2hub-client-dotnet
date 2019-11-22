using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Bank
{
    // internal
    public class Bank
    {
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "swiftbic", Required = Required.Always)]
        public string Swiftbic { get; set; }

        [JsonProperty(PropertyName = "_links", Required = Required.Always)]
        public Links Links { get; set; }
    }
}
