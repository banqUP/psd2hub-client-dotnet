namespace Psd2Hub.Sdk.Models.PaymentForm
{
    public class Field
    {
        internal Field(ApiModels.PaymentForm.Field apiModel)
        {
            Label = apiModel.Label;
            Type = apiModel.Type;
        }

        public string Label { get; }
        public string Type { get; }
    }
}
