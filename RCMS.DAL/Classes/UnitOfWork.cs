using System;
using System.Data.Entity;
using RCMS.DAL.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Classes
{
    public class UnitOfWork : RcmsContext, IUnitOfWork
    {
        private readonly Repository<Category> _categoryRepository;
        private readonly Repository<User> _userRepository;
        private readonly Repository<Item> _itemRepository;
        private readonly Repository<Vendor> _vendoRepository;
        private readonly Repository<InvoiceMaster> _invoiceMasterRepository; 
        private readonly Repository<InvoiceDetail> _invoiceDetailRepository;
        private readonly Repository<ExpenseType> _expenseTypeRepository;
        private readonly Repository<ProductUnit> _productUnitRepository;
        private readonly Repository<Payment> _paymentRepository;
        private readonly Repository<Receiveables> _receiveableRepository;
        private readonly Repository<Expense> _expenseRepository;
        private readonly Repository<Customer> _customerRepository;


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<InvoiceMaster> InvoiceMasters { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Receiveables> Receiveables { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<User> Users { get; set; }
        

        public UnitOfWork()
        {
            _categoryRepository = new Repository<Category>(Categories);
            _userRepository = new Repository<User>(Users);
            _customerRepository = new Repository<Customer>(Customers);
            _itemRepository = new Repository<Item>(Items);
            _invoiceMasterRepository = new Repository<InvoiceMaster>(InvoiceMasters);
            _invoiceDetailRepository =new Repository<InvoiceDetail>(InvoiceDetails);
            _vendoRepository = new Repository<Vendor>(Vendors);
            _expenseRepository = new Repository<Expense>(Expenses);
            _expenseTypeRepository = new Repository<ExpenseType>(ExpenseTypes);
            _receiveableRepository = new Repository<Receiveables>(Receiveables);
            _paymentRepository = new Repository<Payment>(Payments);
            _productUnitRepository = new  Repository<ProductUnit>(ProductUnits);
            
        }
        
        public IRepository<Category> CategoryRepository { get { return _categoryRepository; } }
        public IRepository<User> UserRepository { get { return _userRepository; } }
        public IRepository<Customer> CustomeRepository { get { return _customerRepository; } }
        public IRepository<Item> ItemRepository { get { return _itemRepository; } }
        public IRepository<Payment> PaymentRepository { get { return _paymentRepository; } }
        public IRepository<InvoiceMaster> InvoiceMaster { get { return _invoiceMasterRepository; } }
        public IRepository<InvoiceDetail> InvoiceDetail { get { return _invoiceDetailRepository; } }
        public IRepository<Vendor> VendorRepository { get { return _vendoRepository; } }
        public IRepository<Expense> ExpenseRepository { get { return _expenseRepository; } }
        public IRepository<ExpenseType> ExpenseTypeRepository { get { return _expenseTypeRepository; } }
        public IRepository<Receiveables> ReceiveableRepository { get { return _receiveableRepository; } }
        public IRepository<ProductUnit> ProductUnitRepository { get { return _productUnitRepository; } }
        public void Commit()
        {
            this.SaveChanges();
        }

        public async void CommitAsync()
        {
            await this.SaveChangesAsync();
        }
    }
}