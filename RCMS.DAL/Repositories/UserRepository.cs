using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories
{
    public class UserRepository : RepositoryBase<User> , IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }


        public User UserLogin(User userToLogin)
        {
            throw new System.NotImplementedException();
        }
    }
}
