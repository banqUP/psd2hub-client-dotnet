using Psd2Hub.Sdk.RestClient;
using System;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Payment
{
    public class Payment
    {
        private readonly IRestClient _restClient;

        public Payment()
        {
        }

        internal Payment(IRestClient restClient, ApiModels.Payment.Payment apiModel)
        {
            _restClient = restClient;
            Id = apiModel.Id;
            Status = apiModel.Status;
            Links = new PaymentLinks(apiModel.Links);
        }

        public Guid Id { get; set; }
        public string Status { get; set; }
        public PaymentLinks Links { get; set; }

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
