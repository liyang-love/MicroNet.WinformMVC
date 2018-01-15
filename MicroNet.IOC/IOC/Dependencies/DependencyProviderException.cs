
using System;
using   MicroNet.Helpers;
using     MicroNet.IOC.Exceptions;
using     MicroNet.IOC.Helpers;

namespace     MicroNet.IOC.Dependencies
{
    static class DependencyProviderException
    {
        internal static Exception DependencyUnregistered(Type targetType)
        {
            return new DependencyNotFoundException(
                ExceptionFormatter.Format(Resources.ObjectBuilderRegisteredWithTypeCanNotBeFound, targetType.ToTypeName()));
        }
    }
}
