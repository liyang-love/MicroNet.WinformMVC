using System;
using    MicroNet.WinformMVC.Filters.Contexts;

namespace    MicroNet.WinformMVC.Filters
{
    /// <summary>
    /// The authorization filter. This filter is executed before any other filter
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public abstract class AuthorizationFilterAttribute : Attribute, IAuthorizationFilter
	{
        /// <summary>
        /// The unique method that is executed before all other filters
        /// </summary>
        /// <param name="filterContext">The context of execution</param>
		public virtual void OnAuthorization(AuthorizationContext filterContext)
		{
		}
	}
}