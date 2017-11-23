using System;
using RCMS.Models;

namespace RCMS.DAL.Classes
{
    public class UnitOfWork : IDisposable
    {
        private RcmsContext Context = new RcmsContext("name = Main");
        private Repository<Item> _itemRepository;
        private Repository<Customers> _customerRepository;
        private Repository<Addresses> _addressRepository;
        private Repository<Category> _categoryRepository;
        private Repository<Order> _orderRepository;

        public Repository<Item> ItemRepository => this._itemRepository ?? new Repository<Item>(Context);
        public Repository<Customers> CustomerRepository => this._customerRepository ?? new Repository<Customers>(Context);
        public Repository<Addresses> AddressRepository => this._addressRepository ?? new Repository<Addresses>(Context);
        public Repository<Category> CategoryRepository => this._categoryRepository ?? new Repository<Category>(Context);
        public Repository<Order> OrderRepository => this._orderRepository ?? new Repository<Order>(Context);

        public void Save()
        {
            Context.SaveChanges();
        }

        private bool disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
            
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }
    }
}