using RCMS.DAL.Repositories.Interfaces;

namespace RCMS.DAL.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        ICategoryRepository CategoryRepository { get; }
      IProductUnitsRepository ProductUnitsRepository { get; }
        IUserRepository UserRepository { get; }
        IAddressesRepository AddressesRepository { get; }
        IItemRepository ItemRepository { get; }
        IVendorRepository VendorRepository { get; }
        IReceiveablesRepository ReceiveablesRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IInvoiceMasterRepository InvoiceMasterRepository { get; }
        IInvoiceDetailRepository InvoiceDetailRepository { get; }
        IExpenseTypeRepository ExpenseTypeRepository { get; }
        IExpenseRepository ExpenseRepository { get; }
        
        void Commit();
    }
}
