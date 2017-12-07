﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using RCMS.Commons.HelperClasses;
using RCMS.DAL;
using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;

namespace RCMS.App.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        #region private fields
        
        private readonly Navigation _navigation;
        private readonly IUnitOfWork _unitOfWork;
        private string _username;
        private string _password;
        #endregion

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                SetProperty(ref _username, value);
                RaisePropertyChanged("UserName");
                CanAttemptLogin("abs");
            }
        }

        private User User { get; set; }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetProperty(ref _password, value);
                CanAttemptLogin("sf");
            }
        }

        public DelegateCommand<string> Home { get; private set; }
        public IRegionManager RegionManager;
        public LoginViewModel(IRegionManager regionManager)
        {
          
            _navigation = new Navigation(regionManager);
           
            Home = new DelegateCommand<string>(AttemptLogin );
        }

        public bool CanAttemptLogin(string arg)
        {
            return !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password);
        }

        private void AttemptLogin(string path)
        {
//            IEnumerable<User> users = _unitOfWork.UserRepository.GetAll();
//            User = users.First(user => user.Name == UserName && Password == user.Password);
//            if (User.IsActive)
//            {
//                var wind = Application.Current.Windows.OfType<Window>().SingleOrDefault(window => window.IsActive);
//                wind.Close();
//            }
        }
            
    }
}
