using System.Collections.Generic;
using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class ReceiveablesRepository : RepositoryBase<Receiveables>, IReceiveablesRepository
    {
        public ReceiveablesRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
