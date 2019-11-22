namespace Psd2Hub.Sdk.Models.Bank
{
    public class Links
    {
        internal Links(ApiModels.Bank.Links apiModel)
        {
            GetPaymentForms = apiModel.GetPaymentForms;
        }

        public string GetPaymentForms { get; }
    }
}
