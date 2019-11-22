using Psd2Hub.Sdk.ApiClient;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Psd2Hub.Sdk.Tests
{
    class ApiClientMock : IApiClient
    {
        public Task<TResponse> Execute<TResponse>(string resource, Method method)
        {
            object result = default;

            // api niech dostaje BASE URL w konsturktorze/static facotry
            // MakePayment(string callbackUrl)

            switch (resource)
            {
                case Api.BanksResource:
                    result = new[]
                    {
                        new ApiModels.Bank.Bank
                        {
                            Name = "Openbankig Hackathon Bank",

                        }
                    };
                    break;
            }

            return Task.FromResult((TResponse)result);
        }

        public Task<TResponse> Execute<TResponse, TRequest>(string resource, Method method, TRequest body)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteNoContent(string resource, Method method)
        {
            throw new NotImplementedException();
        }
    }
}
