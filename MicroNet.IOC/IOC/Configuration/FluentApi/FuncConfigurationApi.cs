
using System;
using   MicroNet.Foundation;
using     MicroNet.IOC.Configuration.Provider;
using     MicroNet.IOC.Core;
using     MicroNet.IOC.Injection.Func;

namespace     MicroNet.IOC.Configuration.FluentApi
{
    class FuncConfigurationApi<T> : CommonConfigurationApi
    {
        FuncRegistrationProvider<T> _provider;

        public ICommonConfigurationApi CreateRegistrationProvider(Kernel kernel, Func<IResolutionContext, T> factory, Type concreteType)
        {
            _provider = new FuncRegistrationProvider<T>(kernel)
            {
                Factory = factory,
                ContractType = typeof(T),
                ConcreteType = concreteType
            };

            SetRegistrationProvider(_provider);
            return this;
        }
    }
}
