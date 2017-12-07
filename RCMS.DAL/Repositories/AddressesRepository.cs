using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class AddressesRepository : RepositoryBase<Addresses>, IAddressesRepository
    {
        public AddressesRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}