using     MicroNet.IOC.Core;

namespace     MicroNet.IOC
{
    public interface IRegistrationModule
    {
        void Register(IObjectRegistrar registrar);
    }
}
