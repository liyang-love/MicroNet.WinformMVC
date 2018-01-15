using System;
using  MicroNet.WinformMVC.DataBinding;

namespace  MicroNet.Views.Model
{
    public class LoginModel
    {
        [DataBinding]
        public string LoginName { get; set; }
        [DataBinding]
        public string Password { get; set; }
    }
}