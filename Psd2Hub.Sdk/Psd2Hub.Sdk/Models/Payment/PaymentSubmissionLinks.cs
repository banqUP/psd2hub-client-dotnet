namespace Psd2Hub.Sdk.Models.Payment
{
    public class PaymentSubmissionLinks
    {
        public PaymentSubmissionLinks()
        {
        }

        internal PaymentSubmissionLinks(ApiModels.Payment.PaymentSubmissionLinks apiModel)
        {
            Payment = apiModel.Payment;
            Sca = apiModel.Sca;
        }

        public string Payment { get; set; }
        public string Sca { get; set; }
    }
}
