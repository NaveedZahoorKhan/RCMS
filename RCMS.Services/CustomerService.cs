using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        public CustomerService(IUnitOfWork unitOfWork, IRepository<Customer> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return UnitOfWork.CustomerRepository.GetAll();
        }

        public IEnumerable<Customer> GetCustomersWithoutUnits()
        {
            throw new System.NotImplementedException();
        }


        public Customer GetCustomer(int id)
        {
            return UnitOfWork.CustomerRepository.GetById(id);
        }

        public void CreateCustomer(Customer customer)
        {
            UnitOfWork.CustomerRepository.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            UnitOfWork.CustomerRepository.Update(customer);
        }

        public void SaveCustomer()
        {
            UnitOfWork.Commit();
        }
    }
}
