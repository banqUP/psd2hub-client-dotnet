namespace Psd2Hub.Sdk.Models.Payment
{
    public class FormLinks
    {
        public FormLinks()
        {
        }

        internal FormLinks(ApiModels.Payment.FormLinks apiModel)
        {
            MakePayment = apiModel.MakePayment;
        }

        public string MakePayment { get; set; }
    }
}
