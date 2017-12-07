using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IUserService : IService<User>
    {
        User UserLogin(User userToLogin);
        void Logout();
        void CreateUser(User user);
        void CreateUsers(IEnumerable<User> users);
        IEnumerable<User> GetAllUser();
        void RefreshEntity(User user);
        User GetUserById(int id);
        void SaveUser();
    }
}
