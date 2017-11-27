using Prism.Commands;
using Prism.Mvvm;

namespace RCMS.App.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private bool _sidemenuwidth;

        public DelegateCommand MouseEntered { get; set; }

      

        public bool SideMenuWidth
        {
            get { return _sidemenuwidth; }
            set { SetProperty(ref _sidemenuwidth, value); }
        }
        public MainWindowViewModel()
        {
            MouseEntered = new DelegateCommand(ToggleMenu);
           
        }

       
        private void ToggleMenu()
        {

            SideMenuWidth = SideMenuWidth != true;
        }
    }
}
