using Psd2Hub.Sdk.ApiClient;
using Psd2Hub.Sdk.Models.Bank;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk
{
    // internal
    public class Api : IApi
    {
        public const string BanksResource = "/api/bank";

        private readonly IApiClient _apiClient;

        // internal
        public Api(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<Bank[]> GetBanks()
        {
            var response = await _apiClient.Get<ApiModels.Bank.Bank[]>(BanksResource);
            return response.Select(b => new Bank(_apiClient, b)).ToArray();
        }
    }
}
