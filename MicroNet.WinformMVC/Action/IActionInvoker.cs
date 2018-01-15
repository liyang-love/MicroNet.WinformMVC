
namespace    MicroNet.WinformMVC.Action
{
    public interface IActionInvoker
    {
        void InvokeAction(BaseController context, object[] parameters);
    }
}