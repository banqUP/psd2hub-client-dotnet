using Psd2Hub.Sdk.ApiClient;
using System;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Payment
{
    public class Payment
    {
        private readonly IApiClient _apiClient;

        internal Payment(IApiClient apiClient, ApiModels.Payment.Payment apiModel)
        {
            _apiClient = apiClient;
            Id = apiModel.Id;
            Status = apiModel.Status;
            Links = new Links(apiModel.Links);
        }

        public Guid Id { get; }
        public string Status { get; }
        public Links Links { get; }

        public Task Cancel()
        {
            if (Links.Cancel == null)
            {
                throw new NotSupportedException($"Payment {Id} does not support cancellation.");
            }

            return _apiClient.ExecuteNoContent(Links.Cancel, RestSharp.Method.DELETE);
        }
    }
}
