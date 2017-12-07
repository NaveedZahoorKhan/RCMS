using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class ExpenseTypeRepository : RepositoryBase<ExpenseType>, IExpenseTypeRepository
    {
        public ExpenseTypeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}