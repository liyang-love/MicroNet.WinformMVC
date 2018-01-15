using System;
using System.Linq;
using System.Windows.Forms;
using  MicroNet.Domain;
using  MicroNet.Views.Model;
using  MicroNet.Views.Utils;
using    MicroNet.WinformMVC.Filters;
using    MicroNet.WinformMVC.Filters.Contexts;

namespace  MicroNet.Filters
{
    public class RoleBasedAuthorizationAttribute : AuthorizationFilterAttribute
    {
        string[] _rolesSplit;

        public string Roles { get; set; }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null) 
                throw new ArgumentNullException("");

            object login;
            if (!filterContext.Session.TryGetData(Constant.RoleSessionKey, out login))
            {
                //Display the message
                MessageBox.Show("You are not login. Please login first.", "Not Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filterContext.Result = filterContext.Controller.Open(Constant.LoginController, new LoginModel());
                return;
            }

            _rolesSplit = _rolesSplit ?? SplitString(Roles);
            var objLogin = login as Login;
            if (!_rolesSplit.Contains(objLogin.Role))
            {
                MessageBox.Show("You does not have permission to execute this action, please login with appropriate user!", "Insufficient right", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filterContext.Result = filterContext.Controller.Open(Constant.LoginController, new LoginModel());
            }
        }

        string[] SplitString(string original)
        {
            if (String.IsNullOrEmpty(original))
            {
                return new string[0];
            }

            var split = from piece in original.Split(',')
                        let trimmed = piece.Trim()
                        where !String.IsNullOrEmpty(trimmed)
                        select trimmed;
            return split.ToArray();
        }
    }
}
