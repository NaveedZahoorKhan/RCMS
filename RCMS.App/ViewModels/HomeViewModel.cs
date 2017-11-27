using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Wpf;
using Prism.Regions;
using RCMS.Commons.HelperClasses;

namespace RCMS.App.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private string _title = "Retail Chain Management System";
        private string _profilepic = @"../Resources/icons/profile-default-male.png";
        private string _designation = "Developer";
        private string _name = "Enn Zee";
        private string _myclock;
        private bool _ringDisplay = false;

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

        public bool RingDisplay
        {
            get { return _ringDisplay; }
            set { SetProperty(ref _ringDisplay, value); }
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
        public DelegateCommand<string> Billing { get; private set; }
        public DelegateCommand<string> Management { get; private set; }
        public Navigation Navigation { get; set; }

        public HomeViewModel(IRegionManager regionManager)
        {
            Navigation = new Navigation(regionManager);
            Billing = new DelegateCommand<string>(Navigator);
            Management = new DelegateCommand<string>(Navigator);

//            SideBar = new DelegateCommand(() => );
                DispatcherTimer dispatcherTimer = new DispatcherTimer(new TimeSpan(0,0,1),DispatcherPriority.Normal,
                    delegate
                    {
                        MyClock = DateTime.Now.ToString("HH:mm:ss");
                    }, Dispatcher.CurrentDispatcher);


            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2015",
                    Values = new ChartValues<double> {10, 50, 39, 50}
                },
                new ColumnSeries
                {
                    Title = "2016",
                    Values = new ChartValues<double> {11, 56, 42}
                }
            };

            //adding series will update and animate the chart automatically

            //also adding values updates and animates the chart automatically
            SeriesCollection[1].Values.Add(48d);

            Labels = new[] { "Maria", "Susan", "Charles", "Frida" };
            Formatter = value => value.ToString("N");

        }

        private void Navigator(string path)
        {
            RingDisplay = true;
            Navigation.Navigate(path);
        }
    }
}
