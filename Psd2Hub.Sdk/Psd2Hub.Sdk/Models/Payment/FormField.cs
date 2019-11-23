namespace Psd2Hub.Sdk.Models.Payment
{
    public class FormField
    {
        public FormField()
        {
        }

        internal FormField(ApiModels.Payment.FormField apiModel)
        {
            Label = apiModel.Label;
            Type = apiModel.Type;
        }

        public string Label { get; set; }
        public string Type { get; set; }
    }
}
