using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface ICustomerService : IService<Customer>
    {
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> GetCustomersWithoutUnits();
        Customer GetCustomer(int id);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void SaveCustomer();
        void RefreshEntity(Customer customer);
    }
}
