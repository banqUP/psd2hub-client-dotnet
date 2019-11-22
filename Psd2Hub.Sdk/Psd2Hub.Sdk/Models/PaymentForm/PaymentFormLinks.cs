namespace Psd2Hub.Sdk.Models.PaymentForm
{
    public class PaymentFormLinks
    {
        internal PaymentFormLinks(ApiModels.PaymentForm.PaymentFormLinks apiModel)
        {
            MakePayment = apiModel.MakePayment;
        }

        public string MakePayment { get; }
    }
}
