namespace Psd2Hub.Sdk.Models.Bank
{
    public class BankLinks
    {
        public BankLinks()
        {
        }

        internal BankLinks(ApiModels.Bank.BankLinks apiModel)
        {
            GetPaymentForms = apiModel.GetPaymentForms;
        }

        public string GetPaymentForms { get; set; }
    }
}
