using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class ItemRepository : RepositoryBase<Item> , IItemRepository
    {
        public ItemRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
