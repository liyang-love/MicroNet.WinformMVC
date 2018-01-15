using System;
using     MicroNet.IOC.Lifetimes;

namespace     MicroNet.IOC.Core
{
    public interface IAutoRegistrationPolicy
    {
        bool ShouldRegister(Type concreteType);
        ILifetimeProvider GetLifetimeProvider();
    }

    //public class ControllerAutoRegistrationPolicy : IAutoRegistrationPolicy
    //{
    //    #region IAutoRegistrationRule Members

    //    public bool ShouldRegister(Type concreteType)
    //    {
    //        return typeof(Controller).IsAssignableFrom(concreteType);
    //    }

    //    public ILifetimeProvider GetLifetimeProvider()
    //    {
    //        return new TransientLifetimeProvider();
    //    }

    //    #endregion
    //}
}