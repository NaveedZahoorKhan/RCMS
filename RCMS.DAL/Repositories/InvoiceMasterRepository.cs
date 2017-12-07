using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
   public class InvoiceMasterRepository : RepositoryBase<InvoiceMaster> , IInvoiceMasterRepository
    {
        public InvoiceMasterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
