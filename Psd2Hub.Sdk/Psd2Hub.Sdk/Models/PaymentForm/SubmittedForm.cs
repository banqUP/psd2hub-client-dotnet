using Psd2Hub.Sdk.ApiClient;
using System;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.PaymentForm
{
    public class SubmittedForm
    {
        private readonly IApiClient _apiClient;
      
        internal SubmittedForm(IApiClient apiClient, ApiModels.PaymentForm.SubmittedForm apiModel)
        {
            _apiClient = apiClient;
            Links = new SubmittedFormLinks(apiModel.Links);
            PaymentId = apiModel.PaymentId;
        }

        public Guid PaymentId { get; }
        public SubmittedFormLinks Links { get; }

        public Task CancelPayment()
        {
            if (Links.Cancel == null)
            {
                throw new NotSupportedException($"Payment {PaymentId} does not support cancellation.");
            }

            return _apiClient.ExecuteNoContent(Links.Cancel, RestSharp.Method.DELETE);
        }

        public async Task<Payment.Payment> GetPayment()
        {
            var response = await _apiClient.Get<ApiModels.Payment.Payment>(Links.Payment);
            return new Payment.Payment(_apiClient, response);
        }

        public async Task<string> GetPaymentStatus()
        {
            var response = await _apiClient.Get<ApiModels.Payment.PaymentStatus>(Links.PaymentStatus);
            return response.Value;
        }
    }
}
