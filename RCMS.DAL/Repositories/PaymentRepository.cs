using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class PaymentRepository : RepositoryBase<Payment> , IPaymentRepository
    {
        public PaymentRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
