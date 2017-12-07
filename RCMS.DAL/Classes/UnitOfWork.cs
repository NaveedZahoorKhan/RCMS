using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RCMS.DAL.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Classes
{
    public class UnitOfWork : IUnitOfWork{

        private readonly DbContext entities = null;
        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public UnitOfWork(DbContext entities)
        {
            this.entities = entities;
        }
        public IRepository<T> Repository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)) == true)
            {
                return repositories[typeof(T)] as IRepository<T>;
            }

            IRepository<T> repo = new Repository<T>(entities);
            if (!repositories.Keys.Contains(typeof(T)))
            {
            repositories.Add(typeof(T), repo);

            }
            return repo;
        }

        public void SaveChanges()
        {
            entities.SaveChanges();
        }

         }
}