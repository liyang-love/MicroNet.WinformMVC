using    MicroNet.WinformMVC.Filters.Contexts;

namespace    MicroNet.WinformMVC.Filters
{
    /// <summary>
    /// Authorization filter interface
    /// </summary>
    public interface IAuthorizationFilter
    {
        /// <summary>
        /// The unique method that is executed before all other filters
        /// </summary>
        /// <param name="filterContext">The context of execution</param>
        void OnAuthorization(AuthorizationContext filterContext);
    }
}
