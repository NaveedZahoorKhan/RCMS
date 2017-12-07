using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RCMS.DAL.Infrastructure.Interfaces;

namespace RCMS.DAL.Infrastructure
{
    public abstract class RepositoryBase<TEntity> where TEntity : class
    {
        #region Properties
        private RcmsContext _dataContext;
        private IDbSet<TEntity> _dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected RcmsContext DbContext => _dataContext ?? (_dataContext = DbFactory.Init());

        #endregion

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            _dbSet = DbContext.Set<TEntity>();
        }

        #region Implementation



        /// <summary>
        /// Get TEntity By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }



        /// <summary>
        /// GetSingle TEntity By delegates
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public TEntity GetSingle(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault<TEntity>();
        }



        /// <summary>
        /// GetMany TEntities By delegates
        /// </summary>
        /// <param name="where"></param>
        /// <returns>List typeof TEntity</returns>
        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }



        /// <summary>
        /// GetAll Entities
        /// </summary>
        /// <returns>List typeof TEntity</returns>
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        /// <summary>
        /// GetAll Entities Async
        /// </summary>
        public virtual Task<List<TEntity>> GetAllAsync()
        {
            return Task.Run(() => _dbSet.ToListAsync());
        }

        /// <summary>
        /// GetAll Entities with one include
        /// </summary>
        /// <returns>List typeof TEntity</returns>
        public virtual IEnumerable<TEntity> GetAll(string include)
        {
            return _dbSet.Include(include);
        }




        /// <summary>
        /// GetAll Entities with includes
        /// </summary>
        /// <returns>List typeof TEntity</returns>
        public IEnumerable<TEntity> GetAll(string[] includes)
        {
            return includes.Aggregate<string, IQueryable<TEntity>>(_dbSet, (current, include) => current.Include(include));
        }




        /// <summary>
        /// Mark Add new Entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }



        /// <summary>
        //// Marks an entity as new but more than one entity
        /// </summary>
        /// <param name="entities">IEnumerable typeof TEntity</param>
        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            _dataContext.Set<TEntity>().AddRange(entities);
        }




        /// <summary>
        /// Mark Update Entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dataContext.Entry(entity).State = EntityState.Modified;
        }



        /// <summary>
        /// Mark Delete Entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(TEntity entity)
        {
          DbContext.ChangeTracker.DetectChanges();
                 
            _dbSet.Remove(entity);
        }



        /// <summary>
        /// Mark Delete Entity using delgate
        /// </summary>
        /// <param name="where"></param>
        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = _dbSet.Where<TEntity>(where).AsEnumerable();
            foreach (TEntity obj in objects)
                _dbSet.Remove(obj);
        }



        /// <summary>
        //// Marks an entity to be removed but more than One entity
        /// </summary>
        /// <param name="entities">IEnumerable typeof TEntity</param>
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _dataContext.Set<TEntity>().RemoveRange(entities);
        }



        /// <summary>
        /// Count 
        /// </summary>
        public long Count()
        {
            return _dbSet.Count();
        }



        /// <summary>
        /// Count using a filer
        /// </summary>
        /// <param name="where">Expression typeof TEntity</param>
        public long Count(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where<TEntity>(where).Count();
        }

        /// <summary>
        /// Mark Update Entity
        /// </summary>
        /// <param name="entity"></param>
        public void RefreshEntity(TEntity entity)
        {
            //            _dbSet.Attach(entity);
//            _dbSet.Add(entity);
            _dataContext.Entry(entity).Reload(); // This function should comment to reload entitites
            //            _dataContext.Entry(entity).State = EntityState.Detached;

            //            _dataContext.Entry(entity).State = EntityState.Detached;
            //            _dbSet.Load();
            //            _dbSet = DbContext.Set<TEntity>();

            //            _dbSet.Attach(updatedEntity);

            /*var objectContext = ((IObjectContextAdapter)_dataContext).ObjectContext;
            objectContext.Refresh(RefreshMode.StoreWins, entity);*/
        }
        #endregion

    }
}
