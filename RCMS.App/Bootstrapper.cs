using System.Data.Entity;
using System.Reflection;
using Prism.Unity;
using RCMS.App.Views;
using System.Windows;
using MahApps.Metro.Controls;
using Microsoft.Practices.Unity;
using Prism.Regions;
using RCMS.DAL;
using RCMS.DAL.Classes;
using RCMS.DAL.Interfaces;

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
          
//            Window window = new Login();
//            window.ShowActivated = true;
           // window.ShowDialog( );
            


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

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
               DbContext entities = new RcmsContext();
            Container.RegisterInstance(entities);
            Container.RegisterType<IUnitOfWork, UnitOfWork>();
            UnitOfWork unitOfWork = new UnitOfWork(entities);
            Container.RegisterInstance(unitOfWork);

        }
    }
}
