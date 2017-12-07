using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Mvvm;

namespace RCMS.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            
            base.OnStartup(e);
            IUnityContainer  containers = new UnityContainer();
            ViewModelLocationProvider.SetDefaultViewModelFactory((type) =>
            {
                return containers.Resolve(type);
            });

            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
