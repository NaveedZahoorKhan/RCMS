

using System.Windows;
using Prism.Events;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Unity;
using RCMS.App.Views;
using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Services;
using RCMS.Services.Interfaces;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace RCMS.App
{
    class Bootstrapper : PrismApplication
    {

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(new DbFactory());
            containerRegistry.RegisterInstance(new UnitOfWork(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterSingleton<IEventAggregator, EventAggregator>();
            containerRegistry.RegisterSingleton<IRegionManager, RegionManager>();
            containerRegistry.RegisterInstance(new UserRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new UserService(Container.Resolve<UnitOfWork>(), Container.Resolve<UserRepository>()));
            containerRegistry.RegisterInstance(new VendorRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new VendorService(Container.Resolve<UnitOfWork>(), Container.Resolve<VendorRepository>()));
            containerRegistry.RegisterInstance(new ReceiveablesRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new ReceiveablesService(Container.Resolve<UnitOfWork>(), Container.Resolve<ReceiveablesRepository>()));
            containerRegistry.RegisterInstance(new ProductUnitRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new ProductUnitService(Container.Resolve<UnitOfWork>(), Container.Resolve<ProductUnitRepository>()));
            containerRegistry.RegisterInstance(new PaymentRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new PaymentService(Container.Resolve<UnitOfWork>(), Container.Resolve<PaymentRepository>()));
            containerRegistry.RegisterInstance(new ItemRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new ItemService(Container.Resolve<UnitOfWork>(), Container.Resolve<ItemRepository>()));
            containerRegistry.RegisterInstance(new InvoiceMasterRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new InvoiceMasterService(Container.Resolve<UnitOfWork>(), Container.Resolve<InvoiceMasterRepository>()));
            containerRegistry.RegisterInstance(new InvoiceDetailRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new InvoiceDetailService(Container.Resolve<UnitOfWork>(), Container.Resolve<InvoiceDetailRepository>()));
            containerRegistry.RegisterInstance(new ExpenseRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new ExpenseService(Container.Resolve<UnitOfWork>(), Container.Resolve<ExpenseRepository>()));
            containerRegistry.RegisterInstance(new ExpenseTypeRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new ExpenseTypeService(Container.Resolve<UnitOfWork>(), Container.Resolve<ExpenseTypeRepository>()));
            containerRegistry.RegisterInstance(new CustomerRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new CustomerService(Container.Resolve<UnitOfWork>(), Container.Resolve<CustomerRepository>()));
            containerRegistry.RegisterInstance(new CategoryRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new CategoryService(Container.Resolve<UnitOfWork>(), Container.Resolve<CategoryRepository>()));
            containerRegistry.RegisterInstance(new AddressesRepository(Container.Resolve<DbFactory>()));
            containerRegistry.RegisterInstance(new AddressesService(Container.Resolve<UnitOfWork>(), Container.Resolve<AddressesRepository>()));
            containerRegistry.RegisterSingleton<IRegionManager, RegionManager>();


            ViewModelLocationProvider.SetDefaultViewModelFactory((o, type) => Container.Resolve(type));

        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        

        protected void InitializeShell()
        {
//            Window window = new Login();
//            window.ShowActivated = true;
            // window.ShowDialog( );


            Application.Current.MainWindow.Show();
//            _regionManager = new RegionManager();
//            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Home));
//            Container.RegisterTypeForNavigation<Billing>();
//            Container.RegisterTypeForNavigation<Sales>();
//            Container.RegisterTypeForNavigation<Management>();
//            Container.RegisterTypeForNavigation<Home>();
//            Container.RegisterTypeForNavigation<Orders>();
//            Container.RegisterTypeForNavigation<Purchases>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
         }

        protected void ConfigureContainer()
        {


           
//            Container.RegisterType<IEventAggregator, EventAggregator>(new ContainerControlledLifetimeManager());
//            Container.RegisterType<IUnitOfWork, UnitOfWork>();
//            Container.RegisterType<IDbFactory, DbFactory>();
//            Container.RegisterType<IUnitOfWork, UnitOfWork>("UnitOfWork", new ContainerControlledLifetimeManager());
//            Container.Resolve<IUnitOfWork>("UnitOfWork");
//            Container.RegisterType<IDbFactory, DbFactory>("DbFactory", new ContainerControlledLifetimeManager());
//            Container.Resolve<IDbFactory>("DbFactory");
//            Container.RegisterType<IRegionManager, RegionManager>();
//            Container.RegisterInstance<IRegionManager>(new RegionManager(), new ContainerControlledLifetimeManager());


//            #region Register Repositories

//            Container.RegisterType<IVendorRepository, VendorRepository>();

//            Container.RegisterType<IUserRepository, UserRepository>();
//            Container.RegisterType<IReceiveablesRepository, ReceiveablesRepository>();
//            Container.RegisterType<IProductUnitsRepository, ProductUnitRepository>();
//            Container.RegisterType<IPaymentRepository, PaymentRepository>();
//            Container.RegisterType<IItemRepository, ItemRepository>();
//            Container.RegisterType<IInvoiceMasterRepository, InvoiceMasterRepository>();
//            Container.RegisterType<IInvoiceDetailRepository, InvoiceDetailRepository>();
//            Container.RegisterType<IExpenseTypeRepository, ExpenseTypeRepository>();
//            Container.RegisterType<IExpenseRepository, ExpenseRepository>();
//            Container.RegisterType<ICustomerRepository, CustomerRepository>();
//            Container.RegisterType<ICategoryRepository, CategoryRepository>();
//            Container.RegisterType<IAddressesRepository, AddressesRepository>();
//            #endregion
//            #region Register Services

//            Container.RegisterType<IVendorService, VendorService>();
//            Container.RegisterType<IUserService, UserService>();
//            Container.RegisterType<IReceiveablesService, ReceiveablesService>();
//            Container.RegisterType<IProductUnitService, ProductUnitService>();
//            Container.RegisterType<IPaymentService, PaymentService>();

//            Container.RegisterType<IItemService, ItemService>();
//            Container.RegisterType<InvoiceMasterService, InvoiceMasterService>();
//            Container.RegisterType<IInvoiceDetailService, InvoiceDetailService>();
//            Container.RegisterType<IExpenseTypeService, ExpenseTypeService>();
//            Container.RegisterType<IExpenseService, ExpenseService>();
//            Container.RegisterType<ICustomerService, CustomerService>();
//            Container.RegisterType<ICategoryService, CategoryService>();
//            Container.RegisterType<IAddressesService, AddressesService>();

//            #endregion

//            Container.RegisterType<IDbFactory, DbFactory>("DbFactory", new InjectionConstructor());
//            Container.RegisterType<IUnitOfWork, UnitOfWork>();
//            Container.RegisterType<IDbFactory, DbFactory>();
//            Container.RegisterType<IService, >();
//            Container.RegisterType<IEventAggregator, EventAggregator>(new PerThreadLifetimeManager());

//            Container.RegisterTypeForNavigation<Billing>();
//            Container.RegisterTypeForNavigation<Sales>();
//            Container.RegisterTypeForNavigation<Management>();
//            Container.RegisterTypeForNavigation<Home>();
//            Container.RegisterTypeForNavigation<Orders>();
//            Container.RegisterTypeForNavigation<Purchases>();



        }
    }

   
}