using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.Practices.Unity;
using Microsoft.Win32;
using Prism.Events;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.App.ViewModels
{
    public class ManagementViewModel : BindableBase
    {
        #region Private Fields

        #region User

        private string _username;
        private string _useraddress;
        private string _userimg;
        private string _designation;
        private string _city;
        private string _userCell;
        private string _userPhone;
        private string _password;

        #endregion

        #region Product Unit

        private string _pUUnit;
        private string _pUName;
        private IEnumerable<ProductUnit> _pUnit;

        #endregion
        #region Category

        private string _name;
        private string _discription;
        private string _img;
        private string _lowerlimit;
        private IEnumerable<Category> _categorylist;
        private ICategoryService _categoryService;
        #endregion

        #region Product

        private IEnumerable<Category> _productCategory;
        private ProductUnit _selectedProductUnit;

        private string _productname;
        private string _productcode;
        private double _productdiscount;
        private double _price;
        private string _productImg;
        private IEnumerable<ProductUnit> _productunit;
        private IEnumerable<Item> _itemlist;
        #endregion
        private bool _ringVisibility;

        private IUnitOfWork _unitOfWork;
        private Category _selectedProductCategory;

        private static readonly Random Random = new Random();

        #endregion

       

        #region Properties

        #region Categories

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

        public IEnumerable<Category> CategoryList
        {
            get { return _categorylist; }
            set { SetProperty(ref _categorylist, value); }
        }

      
        #endregion

        #region Products

        public string ProductName
        {
            get { return _productname; }
            set { SetProperty(ref _productname, value); }
        }

        public string ProductCode
        {
            get { return _productcode; }
            set { SetProperty(ref _productcode, value); }
        }

        public double ProductPrice
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }

        public double ProductDiscount
        {
            get { return _productdiscount; }
            set { SetProperty(ref _productdiscount, value); }
        }

        public IEnumerable<Category> ProductCategory
        {
            get { return _productCategory; }
            set { SetProperty(ref _productCategory, value); }
        }

        public IEnumerable<ProductUnit> ProductUnit
        {
            get { return _productunit; }
            set { SetProperty(ref _productunit, value); }
        }
        public DelegateCommand ProductSave { get; private set; }

        public string ProductImg
        {
            get { return _productImg; }
            set { SetProperty(ref _productImg, value); }
        }

        public DelegateCommand ProductBrowse { get; private set; }
        
        #endregion

        #endregion

        #region Methods

        #region Category

        private void SaveCategory()
        {
            Category category = new Category
            {
                Name = Name,
                CategoryImage = Img,
                Description = Discription,
                ItemLowerLimit = LowerLimit,
                DateCreated = DateTime.Now
            };
           
            //    category.CategoryOrder = OrderBy[0].CategoryOrder;
             InitVals();
        }

        private void PopulateCategories()
        {
            CategoryList = ProductCategory;

        }
        #endregion

        #region Others

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
        
        public ManagementViewModel( IEventAggregator eventAggregator, ICategoryService categoryService1)
        {
            _categoryService = categoryService1;
            ProductSave = new DelegateCommand(SaveProduct);
            Save = new DelegateCommand(SaveCategory);
            Browse = new DelegateCommand(() => Img = RaiseBrowseWindow());
            ProductBrowse = new DelegateCommand(() => ProductImg = RaiseBrowseWindow());
            Thread thread = new Thread(PopulateCategories);
            thread.Start();
//            Thread thread2 = new Thread(() => ItemList = _unitOfWork.Repository<Item>().GetAll().ToList());
//            thread2.Start();
            Thread thread3 = new Thread( GetProductUnit);
            thread3.Start();
            PUSave = new DelegateCommand(SaveProductUnit);
//            Thread thread4 = new Thread(() => PUnit = _unitOfWork.Repository<ProductUnit>().GetAll().ToList());
//            thread4.Start();
//            new Thread( () => ProductCategory = _unitOfWork.Repository<Category>().GetAll().ToList()).Start();
        }

        private void GetProductUnit()
        {
//            ProductUnit= _unitOfWork.Repository<ProductUnit>().GetAll();
         
            RingVisibility = false;
        }
        private void SaveProductUnit()
        {
            Models.ProductUnit productUnit = new ProductUnit();
            productUnit.Unit = PUUnit;
            productUnit.UnitFullName = PUName;
//            _unitOfWork.Repository<ProductUnit>().Add(productUnit);
//            _unitOfWork.SaveChanges();
           
        }
        private void SaveProduct()
        {
            Item item = new Item();
            item.Code = ProductCode;
            item.Category = SelectedProductCategory;
            item.ProductUnit = SelectedProductUnit;
            item.DiscoutPercent = ProductDiscount;
            item.Name = ProductName;
            item.Price = ProductPrice;
            
//           _unitOfWork.Repository<Item>().Add(item);
        }

        private string RaiseBrowseWindow()
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Title = "Please select an Image";
            dialog.Filter = "Image Files | *.jpg;*.png;*.jpeg;";
            var res = dialog.ShowDialog();
            if (!res.Equals(true)) return null;
            return dialog.FileName;
        }

        private void InitVals()
        {
            Name = null;
            Img = null;
            Discription = null;
        }

        #endregion

        #endregion
        public DelegateCommand PUSave { get; private set; }

        public DelegateCommand Browse { get; private set; }

        public DelegateCommand Save { get; private set; }
      
        public bool RingVisibility
        {
            get { return _ringVisibility; }
            set { _ringVisibility = value; }
        }

        public IEnumerable<Item> ItemList
        {
            get { return _itemlist; }
            set { _itemlist = value; }
        }

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string UserAddress
        {
            get { return _useraddress; }
            set { _useraddress = value; }
        }

        public string UserImg
        {
            get { return _userimg; }
            set { _userimg = value; }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string UserCell
        {
            get { return _userCell; }
            set { _userCell = value; }
        }

        public string UserPhone
        {
            get { return _userPhone; }
            set { _userPhone = value; }
        }

        public ProductUnit SelectedProductUnit
        {
            get { return _selectedProductUnit; }
            set { SetProperty(ref _selectedProductUnit, value); }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Category SelectedProductCategory
        {
            get { return _selectedProductCategory; }
            set { _selectedProductCategory = value; }
        }

        public string PUUnit
        {
            get { return _pUUnit; }
            set { _pUUnit = value; }
        }

        public string PUName
        {
            get { return _pUName; }
            set { _pUName = value; }
        }
        public IEnumerable<ProductUnit> PUnit
        {
            get { return _pUnit; }
            set
            {
                SetProperty(ref _pUnit, value);
                RaisePropertyChanged("PUnit");
            }
        }
    }
}