using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IVendorService : IService<Vendor>
    {
        IEnumerable<Vendor> GetVendors();
        Vendor GetVendor(int id);
        void CreateVendor(Vendor vendor);
        void UpdateVendor(Vendor vendor);
        void SaveVendor();
        IEnumerable<Vendor> GetVendorsWithoutUnits();
        void RefreshEntity(Vendor vendor);
    }
}
