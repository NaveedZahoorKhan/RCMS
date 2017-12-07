using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IAddressesService : IService<Addresses>
    {
        IEnumerable<Addresses> GetAddresseses();
        Addresses GetAddresses(int id);
        void CreateAddresses(Addresses addresses);
        void UpdateAddresses(Addresses addresses);
        void SaveAddresses();
        void RefreshEntity(Addresses addresses);
    }

  
}
