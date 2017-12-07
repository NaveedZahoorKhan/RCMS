using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class AddressesService : ServiceBase<Addresses>, IAddressesService
    {
        public AddressesService(IUnitOfWork unitOfWork, IRepository<Addresses> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Addresses> GetAddresseses()
        {
            var addresses = UnitOfWork.AddressesRepository.GetAll();
            return addresses;
        }

        public Addresses GetAddresses(int id)
        {
            return UnitOfWork.AddressesRepository.GetById(id);
        }

        public void CreateAddresses(Addresses addresses)
        {
           UnitOfWork.AddressesRepository.Add(addresses);
        }

        public void UpdateAddresses(Addresses addresses)
        {
            UnitOfWork.AddressesRepository.Update(addresses);
        }

        public void SaveAddresses()
        {
            UnitOfWork.Commit();
        }
    }

  
}
