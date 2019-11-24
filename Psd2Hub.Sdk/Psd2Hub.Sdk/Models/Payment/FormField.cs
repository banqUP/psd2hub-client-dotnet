using System.Collections.Generic;

namespace Psd2Hub.Sdk.Models.Payment
{
    public class FormField
    {
        internal FormField(ApiModels.Payment.FormField apiModel)
        {
            Choices = apiModel.Choices;
            Label = apiModel.Label;
            Required = apiModel.Required;
            Type = apiModel.Type;
        }

        public Dictionary<string, string> Choices { get; }
        public string Label { get; }
        public bool Required { get; }
        public string Type { get; }
    }
}
