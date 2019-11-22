using Psd2Hub.Sdk.ApiClient;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Bank
{
    public class Bank
    {
        private readonly IApiClient _apiClient;

        internal Bank(IApiClient apiClient, ApiModels.Bank.Bank apiModel)
        {
            _apiClient = apiClient;
            Name = apiModel.Name;
            Swiftbic = apiModel.Swiftbic;
            Links = new Links(apiModel.Links);
        }

        public string Name { get; }
        public bool SupportsPis { get; }
        public string Swiftbic { get; }
        public Links Links { get; }

        public async Task<PaymentForm.PaymentForm[]> GetPaymentForms()
        {
            if (!SupportsPis)
            {
                throw new NotSupportedException($"Bank {Name} ({Swiftbic}) does not support PIS.");
            }

            return (await _apiClient.Get<ApiModels.PaymentForm.PaymentForm[]>(Links.GetPaymentForms))
                .Select(pf => new PaymentForm.PaymentForm(_apiClient, pf))
                .ToArray();
        }
    }
}
