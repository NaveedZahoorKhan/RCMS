using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RCMS.DAL.Infrastructure.Interfaces;

namespace RCMS.Services
{
    public class ServiceBase<TEntity> where TEntity : class
    {
        protected IRepository<TEntity> Repository;
        public ServiceBase(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            UnitOfWork = unitOfWork;
            Repository = repository;
        }

        protected IUnitOfWork UnitOfWork { get; }

        public virtual TEntity GetById(int id)
        {
            return Repository.GetById(id);
        }
       

        public virtual TEntity GetSingle(Expression<Func<TEntity, bool>> @where)
        {
            return Repository.GetSingle(@where);
        }

        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> @where)
        {
            return Repository.GetMany(@where);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Repository.GetAll();
        }

        public virtual IEnumerable<TEntity> GetAll(string include)
        {
            return Repository.GetAll(include);
        }

        public virtual IEnumerable<TEntity> GetAll(string[] includes)
        {
            return Repository.GetAll(includes);
        }

        public virtual void Add(TEntity entity)
        {
            Repository.Add(entity);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            Repository.AddRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            Repository.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            Repository.Delete(entity);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> @where)
        {
            Repository.Delete(@where);
        }

        public virtual void DeleteRange(IEnumerable<TEntity> entities)
        {
            Repository.DeleteRange(entities);
        }

        public virtual long Count()
        {
            return Repository.Count();
        }

        public virtual long Count(Expression<Func<TEntity, bool>> @where)
        {
            return Repository.Count(@where);
        }

        public void SaveEntity()
        {
            UnitOfWork.Commit();
        }

        public void RefreshEntity(TEntity entity)
        {
            Repository.RefreshEntity(entity);
        }
    }
}
