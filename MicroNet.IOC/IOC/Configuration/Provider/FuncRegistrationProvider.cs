using   MicroNet.Foundation;
using   MicroNet.Helpers;
using     MicroNet.IOC.Configuration.Injection;
using     MicroNet.IOC.Core;
using     MicroNet.IOC.Injection.Func;
using     MicroNet.IOC.Lifetimes;
using System;

namespace     MicroNet.IOC.Configuration.Provider
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    class FuncRegistrationProvider<T> : RegistrationProvider<T>
    {
        Func<IResolutionContext, T> _factory;
        InjectionConfigurationSet _configSet;

        public FuncRegistrationProvider(Kernel kernel)
            :base(kernel)
        {
        }

        public Func<IResolutionContext, T> Factory
        {
            get { return _factory; }
            internal set
            {
                Requires.NotNull(value, "factory");
                _factory = value;
            }
        }

        internal override InjectionConfigurationSet CreateInjectionConfigurationSet(ObjectDescription description, ObjectRelation admin)
        {
            if (_configSet != null)
                return _configSet;

            var configGroup = new FuncInjectionConfigurationGroup(description, _factory);
            var configSet = new InjectionConfigurationSet(description, admin, configGroup);
            var interpreter = new FuncInjectionConfigurationInterpreter(configGroup);
            configGroup.InjectionConfigurationInterpreter = interpreter;
            _configSet = configSet;

            return _configSet;
        }

        protected override Lifetime<T> CreateLifetime()
        {
            return LifetimeHelper.CreateLifetime<T>(LifetimeProvider);
        }
    }
}
