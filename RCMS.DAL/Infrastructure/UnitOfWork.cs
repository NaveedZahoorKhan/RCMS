using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private RcmsContext _rcmsContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
          ProductUnitsRepository  = new ProductUnitRepository(dbFactory);
            UserRepository = new UserRepository(dbFactory);
            ExpenseRepository = new ExpenseRepository(dbFactory);
            ExpenseTypeRepository = new ExpenseTypeRepository(dbFactory);
            InvoiceDetailRepository = new InvoiceDetailRepository(dbFactory);
            InvoiceMasterRepository = new InvoiceMasterRepository(dbFactory);
            PaymentRepository = new PaymentRepository(dbFactory);
            AddressesRepository = new AddressesRepository(dbFactory);
            ItemRepository = new ItemRepository(dbFactory);
            VendorRepository = new VendorRepository(dbFactory);
            ReceiveablesRepository= new ReceiveablesRepository(dbFactory);
            CategoryRepository = new CategoryRepository(dbFactory);
            CustomerRepository = new CustomerRepository(dbFactory);
        }

        public RcmsContext RcmsContext => _rcmsContext ?? (_rcmsContext = _dbFactory.Init());


        public ICustomerRepository CustomerRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IProductUnitsRepository ProductUnitsRepository { get; private set; }
        public IUserRepository UserRepository { get; }
        public IAddressesRepository AddressesRepository { get; }
        public IItemRepository ItemRepository { get; }
        public IVendorRepository VendorRepository { get; }
        public IReceiveablesRepository ReceiveablesRepository { get; }
        public IPaymentRepository PaymentRepository { get; }
        public IInvoiceMasterRepository InvoiceMasterRepository { get; }
        public IInvoiceDetailRepository InvoiceDetailRepository { get; }
        public IExpenseTypeRepository ExpenseTypeRepository { get; }
        public IExpenseRepository ExpenseRepository { get; }

        public void Commit()
        {
            _rcmsContext.Commit();
        }

        public void Dispose()
        {
           _rcmsContext.Dispose();
        }

        /*public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);

                var repositoryInstance = Activator.CreateInstance(repositoryType
                    .MakeGenericType(typeof(T)), RpsContext);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }*/
    }
}
