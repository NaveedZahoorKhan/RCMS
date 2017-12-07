using System;
using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class ProductUnitRepository : RepositoryBase<ProductUnit>, IProductUnitsRepository
    {
        public ProductUnitRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
