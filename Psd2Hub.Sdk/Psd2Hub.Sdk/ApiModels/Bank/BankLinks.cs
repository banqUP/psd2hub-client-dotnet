using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Bank
{
    internal class BankLinks
    {
        [JsonProperty(PropertyName = "getPaymentForms")]
        public string GetPaymentForms { get; set; }
    }
}
