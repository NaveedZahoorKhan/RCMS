using System.Reflection;
using Prism.Unity;
using RCMS.App.Views;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Regions;

namespace RCMS.App
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        private RegionManager _regionManager;
        protected override void InitializeShell()
        {
          


            Application.Current.MainWindow.Show();
            _regionManager = new RegionManager();
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Home));  
            Container.RegisterTypeForNavigation<Billing>();
            Container.RegisterTypeForNavigation<Sales>();
            Container.RegisterTypeForNavigation<Management>();
            Container.RegisterTypeForNavigation<Home>();
            Container.RegisterTypeForNavigation<Orders>();
            Container.RegisterTypeForNavigation<Purchases>();
        }
    }
}
