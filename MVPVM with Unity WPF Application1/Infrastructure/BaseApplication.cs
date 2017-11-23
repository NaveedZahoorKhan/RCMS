using System;
using System.Windows;
using Microsoft.Practices.Prism.UnityExtensions;


namespace MVPVM_with_Unity_WPF_Application1.Infrastructure
{
    public abstract class BaseApplication : System.Windows.Application
    {
        public BaseApplication()
        {

        }

        protected abstract UnityBootstrapper GetBootstrapper();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            SplashScreen splashScreen = new SplashScreen("Images\\Splashscreen.png");
            splashScreen.Show(true);
            var bootstrapper = GetBootstrapper();
            bootstrapper.Run();

        }

        protected override void OnExit(ExitEventArgs e)
        {

        }

        private void Log(Exception ex)
        {

        }
    }
}
