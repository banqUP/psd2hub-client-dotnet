using System;
using System.Collections.Generic;
using System.Text;

namespace Psd2Hub.Sdk
{
    internal class ServiceLocator : IServiceLocator
    {
        public TService Get<TService>()
        {
            throw new NotImplementedException();
        }
    }
}
