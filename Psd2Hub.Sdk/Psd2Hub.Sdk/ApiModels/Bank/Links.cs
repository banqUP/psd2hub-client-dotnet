using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Bank
{
    // internal
    public class Links
    {
        [JsonProperty(PropertyName = "getPaymentForms")]
        public string GetPaymentForms { get; set; }
    }
}
