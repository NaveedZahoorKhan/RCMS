﻿using System.Windows;
using System.Windows.Input;
using MahApps.Metro.Controls;
using RCMS.App.ViewModels;

namespace RCMS.App.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

    
}
}
