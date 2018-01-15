using System;
using System.Reflection;

namespace    MicroNet.WinformMVC
{
    public interface IPairManager : IPairProvider
    {
        void RegisterAssembly(Assembly assembly);
        void RegisterController(Type controllerType);
        void RegisterView(Type viewType);
        void VerifyPairs();
    }
}
