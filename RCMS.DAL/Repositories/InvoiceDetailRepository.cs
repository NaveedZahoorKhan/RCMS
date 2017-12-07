using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class InvoiceDetailRepository : RepositoryBase<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
    