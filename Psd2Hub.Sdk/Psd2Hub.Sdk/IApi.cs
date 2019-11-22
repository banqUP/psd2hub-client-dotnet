using Psd2Hub.Sdk.Models.Bank;
using Psd2Hub.Sdk.Models.Payment;
using System;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk
{
    public interface IApi
    {
        Task<Bank[]> GetBanks();
        Task<Payment> GetPayment(Guid id);
    }
}
