using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepository<User> repository) : base(unitOfWork, repository)
        {
        }

        public void CreateUsers(IEnumerable<User> users)
        {
           UnitOfWork.UserRepository.AddRange(users);
        }

        public IEnumerable<User> GetAllUser()
        {
            return UnitOfWork.UserRepository.GetAll();
        }

        public IEnumerable<User> GetUsersWithoutUnits()
        {
            throw new System.NotImplementedException();
        }

        public User GetUserById(int id)
        {
            return UnitOfWork.UserRepository.GetById(id);
        }

        public User UserLogin(User userToLogin)
        {
            throw new System.NotImplementedException();
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }

        public void CreateUser(User User)
        {
            UnitOfWork.UserRepository.Add(User);
        }

        public void UpdateUser(User User)
        {
            UnitOfWork.UserRepository.Update(User);
        }

        public void SaveUser()
        {
            UnitOfWork.Commit();

        }
    }
}
