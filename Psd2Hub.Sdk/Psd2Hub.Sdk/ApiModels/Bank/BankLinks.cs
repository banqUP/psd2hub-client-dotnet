using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Bank
{
    internal class BankLinks
    {
        [JsonProperty(PropertyName = "paymentForms")]
        public string PaymentForms { get; set; }
    }
}
