using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class VendorRepository : RepositoryBase<Vendor> , IVendorRepository
    {
        public VendorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

      
    }
}
