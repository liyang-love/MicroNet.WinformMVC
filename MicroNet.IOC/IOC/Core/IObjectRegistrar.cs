
using     MicroNet.IOC.Configuration;

namespace     MicroNet.IOC.Core
{
    public interface IObjectRegistrar : IHasKernel
    {
        void Register(IRegistrationProvider provider);
    }

    public interface IManualObjectRegistrar : IObjectRegistrar
    {
        void CommitRegistrations();
    }
}
