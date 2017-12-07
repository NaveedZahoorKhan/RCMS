using System;
using RCMS.Models;

namespace RCMS.DAL.Interfaces
{
    public interface IUnitOfWork 
    {
        IRepository<T> Repository<T>() where T : class;

        void SaveChanges();
      
    }
}