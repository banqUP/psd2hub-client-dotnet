using Psd2Hub.Sdk.RestClient;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Bank
{
    public class Bank
    {
        private readonly IRestClient _restClient;
        private readonly BankLinks _links;

        internal Bank(IRestClient restClient, ApiModels.Bank.Bank apiModel)
        {
            _restClient = restClient;
            Logo = apiModel.Logo;
            Name = apiModel.Name;
            Swift = apiModel.Swift;
            _links = new BankLinks(apiModel.Links);
        }

        public byte[] Logo { get; }
        public string Name { get; }
        public string Swift { get; }

        public async Task<Payment.Form[]> GetPaymentForms()
        {
            return (await _restClient.Get<ApiModels.Payment.Form[]>(_links.PaymentForms))
                .Select(pf => new Payment.Form(_restClient, pf))
                .ToArray();
        }
    }
}
