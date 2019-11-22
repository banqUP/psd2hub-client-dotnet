using Psd2Hub.Sdk.RestClient;
using System;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Payment
{
    public class Payment
    {
        private readonly IRestClient _restClient;

        internal Payment(IRestClient restClient, ApiModels.Payment.Payment apiModel)
        {
            _restClient = restClient;
            Id = apiModel.Id;
            Status = apiModel.Status;
            Links = new PaymentLinks(apiModel.Links);
        }

        public Guid Id { get; }
        public string Status { get; }
        public PaymentLinks Links { get; }

        public Task Cancel()
        {
            if (Links.Cancel == null)
            {
                throw new NotSupportedException($"Payment {Id} does not support cancellation.");
            }

            return _restClient.ExecuteNoContent(Links.Cancel, RestSharp.Method.DELETE);
        }
    }
}
