using Prism.Commands;
using Prism.Mvvm;

namespace RCMS.App.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private bool _sidemenuwidth;

        public DelegateCommand HamburgerOpened { get; private set; }
        public DelegateCommand HamburgerClosed { get; private set; }

        public bool SideMenuWidth
        {
            get { return _sidemenuwidth; }
            set { SetProperty(ref _sidemenuwidth, value); }
        }
        public MainWindowViewModel()
        {
            HamburgerOpened = new DelegateCommand(ToggleMenu);
           
        }

       
        private void ToggleMenu()
        {
            if (SideMenuWidth == true)
            {
                SideMenuWidth = false;
            }
            else
            {
                SideMenuWidth = true;
            }
        }
    }
}
