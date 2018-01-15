using     MicroNet.IOC.Configuration.Provider;
using     MicroNet.IOC.Core;

namespace     MicroNet.IOC.Configuration.FluentApi
{
    class InstanceConfigurationApi<T> : CommonConfigurationApi
    {
        InstanceRegistrationProvider<T> _provider;

        public ICommonConfigurationApi CreateRegistrationProvider(Kernel kernel, T instance)
        {
            _provider = new InstanceRegistrationProvider<T>(kernel)
            {
                Instance = instance,
                ContractType = typeof(T),
                ConcreteType = instance.GetType()
            };
            
            SetRegistrationProvider(_provider);
            return this;
        }
    }
}
