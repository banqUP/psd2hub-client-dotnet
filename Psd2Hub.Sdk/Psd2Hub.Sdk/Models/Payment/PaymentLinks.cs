namespace Psd2Hub.Sdk.Models.Payment
{
    public class PaymentLinks
    {
        public PaymentLinks()
        {
        }

        internal PaymentLinks(ApiModels.Payment.PaymentLinks apiModel)
        {
            Self = apiModel.Self;
            Status = apiModel.Status;
            Cancel = apiModel.Cancel;
        }

        public string Self { get; set; }
        public string Status { get; set; }
        public string Cancel { get; set; }
    }
}
