using Psd2Hub.Sdk.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.PaymentForm
{
    public class PaymentForm
    {
        private readonly IApiClient _apiClient;

        internal PaymentForm(IApiClient apiClient, ApiModels.PaymentForm.PaymentForm apiModel)
        {
            _apiClient = apiClient;
            PaymentType = apiModel.PaymentType;
            Links = new PaymentFormLinks(apiModel.Links);
            Fields = apiModel.Fields.ToDictionary(kvp => kvp.Key, kvp => new Field(kvp.Value));
        }

        public string PaymentType { get; }
        public Dictionary<string, Field> Fields { get; }
        public PaymentFormLinks Links { get; }

        public async Task<SubmittedForm> MakePayment(IDictionary<string, object> fields)
        {
            if (fields == null)
            {
                throw new ArgumentNullException(nameof(fields));
            }

            // foreach v in fields czy się zgada z tymi co są w Fields, które mają required

            if (Links.MakePayment == null)
            {
                throw new NotSupportedException($"Payment form {PaymentType} does not support making a payment.");
            }

            var response = await _apiClient.Post<ApiModels.PaymentForm.SubmittedForm, IDictionary<string, object>>(Links.MakePayment, fields);

            return new SubmittedForm(_apiClient, response);
        }
    }
}
