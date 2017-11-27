using System;
using RCMS.Models;

namespace RCMS.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Category> CategoryRepository { get; }
        IRepository<User> UserRepository { get; }
        void Commit();
    }
}