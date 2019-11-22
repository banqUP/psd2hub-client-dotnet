namespace Psd2Hub.Sdk.Models.PaymentForm
{
    public class SubmittedFormLinks
    {
        internal SubmittedFormLinks(ApiModels.PaymentForm.SubmittedFormLinks apiModel)
        {
            Cancel = apiModel.Cancel;
            Payment = apiModel.Payment;
            PaymentStatus = apiModel.PaymentStatus;
        }

        public string Cancel { get; }
        public string Payment { get; }
        public string PaymentStatus { get; }
    }
}
