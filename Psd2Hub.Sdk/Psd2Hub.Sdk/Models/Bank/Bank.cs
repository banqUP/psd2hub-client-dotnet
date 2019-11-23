using Psd2Hub.Sdk.RestClient;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Bank
{
    public class Bank
    {
        private readonly IRestClient _restClient;

        public Bank()
        {
        }

        internal Bank(IRestClient restClient, ApiModels.Bank.Bank apiModel)
        {
            _restClient = restClient;
            Logo = apiModel.Logo;
            Name = apiModel.Name;
            Swift = apiModel.Swift;
            Links = new BankLinks(apiModel.Links);
        }

        public byte[] Logo { get; set; }
        public string Name { get; set; }
        public string Swift { get; set; }
        public BankLinks Links { get; set; }

        public async Task<Payment.Form[]> GetPaymentForms()
        {
            return (await _restClient.Get<ApiModels.Payment.Form[]>(Links.PaymentForms))
                .Select(pf => new Payment.Form(_restClient, pf))
                .ToArray();
        }
    }
}
