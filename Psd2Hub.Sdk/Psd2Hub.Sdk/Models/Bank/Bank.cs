using Psd2Hub.Sdk.RestClient;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Bank
{
    public class Bank
    {
        private readonly IRestClient _restClient;

        internal Bank(IRestClient restClient, ApiModels.Bank.Bank apiModel)
        {
            _restClient = restClient;
            Name = apiModel.Name;
            Swiftbic = apiModel.Swiftbic;
            Links = new BankLinks(apiModel.Links);
        }

        public string Name { get; }
        public string Swiftbic { get; }
        public BankLinks Links { get; }

        public async Task<Payment.Form[]> GetPaymentForms()
        {
            return (await _restClient.Get<ApiModels.Payment.Form[]>(Links.GetPaymentForms))
                .Select(pf => new Payment.Form(_restClient, pf))
                .ToArray();
        }
    }
}
