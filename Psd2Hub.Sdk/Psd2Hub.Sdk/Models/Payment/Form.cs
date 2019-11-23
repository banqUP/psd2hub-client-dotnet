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

        public Form()
        {
        }

        internal Form(IRestClient restClient, ApiModels.Payment.Form apiModel)
        {
            _restClient = restClient;
            PaymentType = (PaymentType)Enum.Parse(typeof(PaymentType), apiModel.PaymentType);
            Links = new FormLinks(apiModel.Links);
            Fields = apiModel.Fields.ToDictionary(kvp => kvp.Key, kvp => new FormField(kvp.Value));
        }

        public PaymentType PaymentType { get; set; }
        public Dictionary<string, FormField> Fields { get; set; }
        public FormLinks Links { get; set; }

        public async Task<PaymentSubmission> SubmitPayment(IDictionary<string, object> fields)
        {
            if (fields == null)
            {
                throw new ArgumentNullException(nameof(fields));
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
