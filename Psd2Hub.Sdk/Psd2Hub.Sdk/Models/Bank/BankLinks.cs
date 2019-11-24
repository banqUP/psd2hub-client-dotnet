namespace Psd2Hub.Sdk.Models.Bank
{
    internal class BankLinks
    {
        internal BankLinks(ApiModels.Bank.BankLinks apiModel)
        {
            PaymentForms = apiModel.PaymentForms;
        }

        public string PaymentForms { get; }
    }
}
