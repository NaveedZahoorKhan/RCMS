using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using RCMS.Commons.HelperClasses;

namespace RCMS.App.ViewModels
{
    public class SideMenuViewModel : BindableBase
    {
        public DelegateCommand<string> Home { get; private set; }
        public DelegateCommand<string> Management { get; private set; }
        public DelegateCommand<string> Sales { get; private set; }
        public DelegateCommand<string> Billing { get; private set; }
        public DelegateCommand<string> Settings { get; private set; }
        public DelegateCommand<string> Reports { get; private set; }
        
        public SideMenuViewModel(RegionManager regionManager)
        {
            var navigation = new Navigation(regionManager);
            Home = new DelegateCommand<string>(navigation.Navigate);
            Management = new DelegateCommand<string>(navigation.Navigate);
            Sales = new DelegateCommand<string>(navigation.Navigate);
            Billing = new DelegateCommand<string>(navigation.Navigate);
            Settings = new DelegateCommand<string>(navigation.Navigate);
            Reports = new DelegateCommand<string>(navigation.Navigate);
        }
    }
}
