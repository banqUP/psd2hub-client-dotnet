using Psd2Hub.Sdk.Extensions;
using Psd2Hub.Sdk.Models.Bank;
using Psd2Hub.Sdk.RestClient;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk
{
    public class ApiClient
    {
        private static readonly SimpleInjector.Container _container;

        private const string _banksResource = "/api/bank";
        
        private readonly IRestClient _restClient;

        static ApiClient()
        {
            _container = new SimpleInjector.Container();
            _container.RegisterApiClientDependencies();
        }

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

            _restClient = _container.GetInstance<IRestClient>();
            _restClient.Url = url;
            _restClient.SubscriptionKey = subscriptionKey;
        }

        public async Task<Bank[]> GetBanks()
        {
            var response = await _restClient.Get<ApiModels.Bank.Bank[]>(_banksResource);
            return response.Select(b => new Bank(_restClient, b)).ToArray();
        }
    }
}
