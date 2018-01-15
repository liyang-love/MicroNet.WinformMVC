using System;
using System.Globalization;
using MicroNet.IOC;
using MicroNet.IOC.Helpers;

namespace MicroNet.Helpers
{
    static partial class Requires
    {
        internal static void IsAutowirableType(Type type, string paramName)
        {
            if (!type.IsAutowirable())
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                                    Resources.SuppliedTypeIsNotAutowirable, type.ToFullTypeName()), paramName);
        }

        internal static void HasOneGenericArgument(Type type, string paramName)
        {
            if (type.GetGenericArguments().Length != 1)
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                                                Resources.SuppliedTypeSupposedToHaveOneGenericArgsOnly, type.ToFullTypeName()), paramName);
        }

        //internal static void HasNoArgumentConstructor(Type type, string paramName)
        //{
        //    IsConcreteType(type, paramName);

        //    if (type.GetConstructor(BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null) == null)
        //        throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, 
        //            Resources.SuppliedTypeDoesNotHaveNonArgsConstructor, type.ToFullTypeName()), paramName);
        //}
    }
}
