using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            //ljkhiokh
            var api = new ApiClient("", "");

            var banks = await api.GetBanks();
            var paymentForm = (await banks.First().GetPaymentForms()).First();

            var result = await paymentForm.SubmitPayment(paymentForm.Fields.ToDictionary(f => f.Key, f => (object)"123"));

            var scaUrl = result.Links.Sca;
            //var status = await result.GetPaymentStatus();
        }
    }
}
