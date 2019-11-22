using Psd2Hub.Sdk.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Models.Payment
{
    public class Form
    {
        private readonly IRestClient _restClient;

        internal Form(IRestClient restClient, ApiModels.Payment.Form apiModel)
        {
            _restClient = restClient;
            PaymentType = Enum.Parse<PaymentType>(apiModel.PaymentType);
            Links = new FormLinks(apiModel.Links);
            Fields = apiModel.Fields.ToDictionary(kvp => kvp.Key, kvp => new FormField(kvp.Value));
        }

        public PaymentType PaymentType { get; }
        public Dictionary<string, FormField> Fields { get; }
        public FormLinks Links { get; }

        public async Task<PaymentSubmission> MakePayment(IDictionary<string, object> fields)
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

            var response = await _restClient.Post<ApiModels.Payment.PaymentSubmission, IDictionary<string, object>>(Links.MakePayment, fields);

            return new PaymentSubmission(_restClient, response);
        }
    }

    public enum PaymentType
    {
        Domestic,
        Eea,
        NonEea,
        Tax,
        Bundle,
        Recurring
    }
}
