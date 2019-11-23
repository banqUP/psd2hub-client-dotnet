using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Bank
{
    internal class Bank
    {
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "swift", Required = Required.Always)]
        public string Swift { get; set; }

        [JsonProperty(PropertyName = "_links", Required = Required.Always)]
        public BankLinks Links { get; set; }
    }
}
