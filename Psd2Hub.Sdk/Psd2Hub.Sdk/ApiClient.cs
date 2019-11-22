using Psd2Hub.Sdk.RestClient;
using Psd2Hub.Sdk.Models.Bank;
using Psd2Hub.Sdk.Models.Payment;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk
{
    public class ApiClient
    {
        public const string BanksResource = "/api/bank";
        
        private readonly IRestClient _restClient;

        public ApiClient(string url, string subscriptionKey)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (subscriptionKey == null)
            {
                throw new ArgumentNullException(nameof(subscriptionKey));
            }

            var locator = new ServiceLocator();

            _restClient = locator.Get<IRestClient>();
            _restClient.Url = url;
            _restClient.SubscriptionKey = subscriptionKey;
        }

        public async Task<Bank[]> GetBanks()
        {
            var response = await _restClient.Get<ApiModels.Bank.Bank[]>(BanksResource);
            return response.Select(b => new Bank(_restClient, b)).ToArray();
        }

        public Task<Payment> GetPayment(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
