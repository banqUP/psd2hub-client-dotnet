namespace Psd2Hub.Sdk.Models.Payment
{
    internal class FormLinks
    {
        internal FormLinks(ApiModels.Payment.FormLinks apiModel)
        {
            MakePayment = apiModel.SubmitPayment;
        }

        public string MakePayment { get; }
    }
}
