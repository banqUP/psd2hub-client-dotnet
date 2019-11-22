using Psd2Hub.Sdk.RestClient;
using System;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Payment
{
    public class PaymentSubmission
    {
        private readonly IRestClient _restClient;
      
        internal PaymentSubmission(IRestClient restClient, ApiModels.Payment.PaymentSubmission apiModel)
        {
            _restClient = restClient;
            Links = new PaymentSubmissionLinks(apiModel.Links);
            PaymentId = apiModel.PaymentId;
        }

        public Guid PaymentId { get; }
        public PaymentSubmissionLinks Links { get; }

        public async Task<Payment> GetPayment()
        {
            return new Payment(
                _restClient, 
                await _restClient.Get<ApiModels.Payment.Payment>(Links.Payment));
        }
    }
}
