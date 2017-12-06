using System;
using RCMS.Models;

namespace RCMS.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
         IRepository<Category> CategoryRepository { get; }
         IRepository<User> UserRepository { get; }
          IRepository<Customer> CustomeRepository { get; }
          IRepository<Item> ItemRepository { get; }
          IRepository<Payment> PaymentRepository { get; }
          IRepository<InvoiceMaster> InvoiceMaster { get; }
         IRepository<InvoiceDetail> InvoiceDetail { get; }
          IRepository<Vendor> VendorRepository { get; }
          IRepository<Expense> ExpenseRepository { get; }
          IRepository<ExpenseType> ExpenseTypeRepository { get; }
          IRepository<Receiveables> ReceiveableRepository { get; }
          IRepository<ProductUnit> ProductUnitRepository { get; }
        void Commit();
        void CommitAsync();
    }
}