
using  MicroNet.Utils;
using    MicroNet.WinformMVC.Filters;
using    MicroNet.WinformMVC.Filters.Contexts;

namespace  MicroNet.Filters
{
    public class NotifyDeleteAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext preContext)
        {
            Logger.Log("NotifyDeleteAttribute.OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext postContext)
        {
            Logger.Log("NotifyDeleteAttribute.OnActionExecuted");
        }
    }
}
