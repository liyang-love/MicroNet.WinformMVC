using System;
using System.Windows.Forms;
using MicroNet.Repository;
using MicroNet.Services;
using MicroNet.Views;
using MicroNet.IOC;
using MicroNet.WinformMVC;

namespace MicroNet.Tests
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var container = new ObjectContainer(false);
                container.Register(typeof(Database)).In(Lifetime.Container());
                container.Register(typeof(ILoginService), typeof(LoginService)).In(Lifetime.Container());
                container.Register(typeof(IContactService), typeof(ContactService)).In(Lifetime.Container());

                IIocWrapper iocWrapper = new IoCWrapper(container);
                IPairManager pairManager = new PairManager();
                pairManager.RegisterAssembly(typeof(LoginView).Assembly);
                pairManager.RegisterAssembly(typeof(Program).Assembly);

                ICoordinator coordinator = new Coordinator(pairManager, iocWrapper);
                coordinator.StartApplication("LoginController");
            }
            catch (Exception ex)
            {
                Console.WriteLine("...初始化应用程序请联系管理员出错的...");
                Environment.Exit(Environment.ExitCode);
            }
        }
    }
}
