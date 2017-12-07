using System;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using Prism.Regions;
using RCMS.App.ViewModels;

namespace RCMS.App.Views
{
    /// <summary>
    /// Interaction logic for Home
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            DataContext = new HomeViewModel(new RegionManager());

        }
        
    }
}
