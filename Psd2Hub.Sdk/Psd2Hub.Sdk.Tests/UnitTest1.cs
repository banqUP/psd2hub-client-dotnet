using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Tests
{
    public class Tests
    {
        [Test]
        public async Task RetrievePaymentScaUrl()
        {
            var api = new ApiClient("http://23.97.141.64", "12323");
            var bank = (await api.GetBanks()).FirstOrDefault();
            var form = (await bank.GetPaymentForms()).FirstOrDefault();

            var fields = new Dictionary<string, object>
            {
                ["amount"] = 40,
                ["currency"] = "PLN",
                ["recipientName"] = "Unicef",
                ["recipientAddress"] = "Adres",
                ["recipientType"] = "typ",
                ["recipientIban"] = "PL03102055610000370200128306",
                ["recipientBankSwift"] = "BPKOPLPW",
                ["senderName"] = "Jan Kowalski",
                ["senderIban"] = "PL61000123450000000009040575",
                ["title"] = "Darowizna",
                ["startDate"] = "2019-11-29",
                ["periodType"] = "Month",
                ["periodValue"] = 1
            };

            var result = await form.SubmitPayment(fields);

            Assert.IsNotNull(result?.ScaUrl);
        }
    }
}
