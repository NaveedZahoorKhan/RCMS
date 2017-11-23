using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Threading;

namespace RCMS.App.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private string _title = "Retail Chain Management System";
        private string _profilepic = @"../Resources/icons/profile-default-male.png";
        private string _designation = "Developer";
        private string _name = "Enn Zee";
        private string _myclock;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ProfilePic
        {
            get { return _profilepic; }
            set { SetProperty(ref _profilepic, value); }
        }

        public string Designation
        {
            get { return _designation; }
            set { SetProperty(ref _designation, value); }
        }

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public string MyClock { get { return (string) _myclock; } set { SetProperty(ref _myclock, value); } }
        public DelegateCommand SideBar { get; set; }

        public HomeViewModel()
        {
//            SideBar = new DelegateCommand(() => );
                DispatcherTimer dispatcherTimer = new DispatcherTimer(new TimeSpan(0,0,1),DispatcherPriority.Normal,
                    delegate
                    {
                        MyClock = DateTime.Now.ToString("HH:mm:ss");
                    }, Dispatcher.CurrentDispatcher);
        }
    }
}
