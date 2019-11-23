namespace Psd2Hub.Sdk.Models.Bank
{
    public class BankLinks
    {
        public BankLinks()
        {
        }

        internal BankLinks(ApiModels.Bank.BankLinks apiModel)
        {
            PaymentForms = apiModel.PaymentForms;
        }

        public string PaymentForms { get; set; }
    }
}
