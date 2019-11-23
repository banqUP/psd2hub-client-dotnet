using System.Collections.Generic;

namespace Psd2Hub.Sdk.Models.Payment
{
    public class FormField
    {
        public FormField()
        {
        }

        internal FormField(ApiModels.Payment.FormField apiModel)
        {
            Choices = apiModel.Choices;
            Label = apiModel.Label;
            Required = apiModel.Required;
            Type = apiModel.Type;
        }

        public Dictionary<string, string> Choices { get; set; }
        public string Label { get; set; }
        public bool Required { get; set; }
        public string Type { get; set; }
    }
}
