using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User UserLogin(User userToLogin);
    }
}
