using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class VendorService : ServiceBase<Vendor>, IVendorService
    {
        public VendorService(IUnitOfWork unitOfWork, IRepository<Vendor> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Vendor> GetVendors()
        {
            return UnitOfWork.VendorRepository.GetAll();
        }

        public Vendor GetVendor(int id)
        {
            return UnitOfWork.VendorRepository.GetById(id);
        }

        public void CreateVendor(Vendor vendor)
        {
            UnitOfWork.VendorRepository.Add(vendor);
        }

        public void UpdateVendor(Vendor vendor)
        {
            UnitOfWork.VendorRepository.Update(vendor);
        }

        public void SaveVendor()
        {
            UnitOfWork.Commit();
        }

        public IEnumerable<Vendor> GetVendorsWithoutUnits()
        {
            throw new System.NotImplementedException();
        }
    }
}
