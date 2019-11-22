namespace Psd2Hub.Sdk.Models.Payment
{
    public class PaymentSubmissionLinks
    {
        internal PaymentSubmissionLinks(ApiModels.Payment.PaymentSubmissionLinks apiModel)
        {
            Payment = apiModel.Payment;
            Sca = apiModel.Sca;
        }

        public string Payment { get; }
        public string Sca { get; }
    }
}
