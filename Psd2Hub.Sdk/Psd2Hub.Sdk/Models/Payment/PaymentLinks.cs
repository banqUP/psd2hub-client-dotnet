namespace Psd2Hub.Sdk.Models.Payment
{
    public class PaymentLinks
    {
        internal PaymentLinks(ApiModels.Payment.PaymentLinks apiModel)
        {
            Self = apiModel.Self;
            Status = apiModel.Status;
            Cancel = apiModel.Cancel;
        }

        public string Self { get; }
        public string Status { get; }
        public string Cancel { get; }
    }
}
