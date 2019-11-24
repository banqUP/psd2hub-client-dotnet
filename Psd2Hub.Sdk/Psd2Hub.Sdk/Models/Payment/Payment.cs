using Psd2Hub.Sdk.RestClient;
using System;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Payment
{
    public class Payment
    {
        private readonly IRestClient _restClient;
        private readonly PaymentLinks _links;

        internal Payment(IRestClient restClient, ApiModels.Payment.Payment apiModel)
        {
            _restClient = restClient;
            Id = apiModel.Id;
            Status = apiModel.Status;
            _links = new PaymentLinks(apiModel.Links);
        }

        public Guid Id { get; }
        public string Status { get; }

        public Task Cancel()
        {
            return _restClient.ExecuteNoContent(_links.Cancel, RestSharp.Method.DELETE);
        }
    }
}
