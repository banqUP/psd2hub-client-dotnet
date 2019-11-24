# banqup SDK

banqUP SDK is a _free, open-source_ client library for .NET that simplifies usage of banqUP PSD2 hub. It lowers the cost to connect and maintain all that your app needs in order to provide multibanking features. 

## Usage examples

### Making a payment in a console app
```csharp

var apiClient = new ApiClient("banqUP API url", "your subscription key");

// Fetch available banks
var bankList = await apiClient.GetBanks();

// Choose in which bank do you want to make a payment
var bank = bankList.Single(b => b.Swift == "SWIFTCODE");

// Fetch payment forms for different payment types available in a given bank
var formList = await bank.GetPaymentForms();

// Choose form for a payment of a given type
var form = formList.Single(f => f.PaymentType == PaymentType.Domestic);

// Provide user with a set of fields to fill
var filledFields = new Dictionary<string, object>();
foreach (var field in form.Fields)
{
	Console.Write($"Input value for {field.Label}: ");
	filledFields[field.Key] = Console.ReadLine();
}

// Submit payment and receive an url for SCA
var submission = await form.SubmitPayment(filledFields);

Console.WriteLine($"Follow the link to authenticate and confirm the payment:");
Console.WriteLine(submission.Links.Sca);
```
