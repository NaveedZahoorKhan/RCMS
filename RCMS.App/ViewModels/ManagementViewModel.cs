using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Threading;
using Microsoft.Win32;
using RCMS.DAL.Classes;
using RCMS.DAL.Interfaces;
using RCMS.Models;

namespace RCMS.App.ViewModels
{
    public class ManagementViewModel : BindableBase
    {
        #region Private Fields

        private string _name;
        private string _discription;
        private string _img;
        private string _lowerlimit;
        private Task<List<Category>> _orderby;
        private IUnitOfWork _unitOfWork;
        private List<Category> _res;

        #endregion
        public ManagementViewModel()
        {
            _unitOfWork = new UnitOfWork();
//            if (OrderBy.Count  <= 0)
//            {
//              var cat =   new Category() {CategoryOrder = 1.ToString()};
//               OrderBy.Add (cat);
//            }
            Browse = new DelegateCommand(RaiseBrowseWindow);
            Save = new DelegateCommand(SaveCategory);
            GetAllImp();
        }

        public void GetAllImp()
        {

//            OrderBy = _unitOfWork.CategoryRepository.GetAllAsync();
//            if (!OrderBy.IsCompleted)
//            {
//               OrderBy.Wait(500);
              
//            }
            Res = (List<Category>) _unitOfWork.CategoryRepository.GetAll();
        }

        public List<Category> Res
        {
            get { return _res; }
            set { _res = value; }
        }

        private void SaveCategory()
        {
            Category category = new Category();
            category.Name = Name;
            category.CategoryImage = Img;
        //    category.CategoryOrder = OrderBy[0].CategoryOrder;
            category.Description = Discription;
            category.ItemLowerLimit = LowerLimit;
            category.DateCreated = DateTime.Now;
            _unitOfWork.CategoryRepository.Insert(category);
            _unitOfWork.Commit();
            Name = null;
            Img = null;
            Discription = null;
        }

        private static readonly Random Random = new Random();

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
        private void RaiseBrowseWindow()
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Title = "Please select an Image";
            dialog.Filter = "Image Files | *.jpg;*.png;*.jpeg;";
            var res = dialog.ShowDialog();
            if (!res.Equals(true)) return;
            Img = dialog.FileName;
            FinalImage = DateTime.Now.Ticks + RandomString(10);
        }

        public DelegateCommand Browse { get; private set; }
        public DelegateCommand Save { get; private set; }
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public string Discription
        {
            get { return _discription; }
            set { SetProperty(ref _discription, value); }
        }

        public string Img
        {
            get { return _img; }
            set { SetProperty(ref _img, value); }
        }

        public string LowerLimit
        {
            get { return _lowerlimit; }
            set { SetProperty(ref _lowerlimit, value); }
        }

        public Task<List<Category>> OrderBy
        {
            get { return _orderby; }
            set { SetProperty(ref _orderby, value); }
        }

        public string FinalImage { get; private set; }
    }
}
