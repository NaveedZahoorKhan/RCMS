using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RCMS.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get an entity using delegate
        /// </summary>
        /// <param name="id"></param>
        TEntity GetById(int id);



        /// <summary>
        /// Get single Entity using delegate
        /// </summary>
        /// <param name="where">Expression typeof TEntity</param>
        TEntity GetSingle(Expression<Func<TEntity, bool>> where);



        /// <summary>
        /// Get a selected extiry by the object primary key ID
        /// </summary>
        /// <param name="where"></param>
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);




        /// <summary>
        /// Gets all entities of type TEntity
        /// </summary>
        IEnumerable<TEntity> GetAll();



        /// <summary>
        /// Gets all entities of type TEntity with include
        /// </summary>
        IEnumerable<TEntity> GetAll(string include);



        /// <summary>
        /// Gets all entities of type TEntity with includes
        /// </summary>
        IEnumerable<TEntity> GetAll(string[] includes);



        /// <summary>
        //// Marks an entity as new but only one entity
        /// </summary>
        /// <param name="entity">TEntity</param>
        void Add(TEntity entity);



        /// <summary>
        //// Marks an entity as new but more than one entity
        /// </summary>
        /// <param name="entities">IEnumerable typeof TEntity</param>
        void AddRange(IEnumerable<TEntity> entities);




        /// <summary>
        //// Marks an entity as modified
        /// </summary>
        /// <param name="entity">TEntity</param>
        void Update(TEntity entity);




        /// <summary>
        //// Marks an entity to be removed but only One entity
        /// </summary>
        /// <param name="entity">TEntity</param>
        void Delete(TEntity entity);


        /// <summary>
        //// Marks an entity to be removed but only One entity
        /// </summary>
        /// <param name="where">Expression</param>
        void Delete(Expression<Func<TEntity, bool>> where);


        /// <summary>
        //// Marks an entity to be removed but more than One entity
        /// </summary>
        /// <param name="entities">IEnumerable typeof TEntity</param>
        void DeleteRange(IEnumerable<TEntity> entities);


        /// <summary>
        /// Count 
        /// </summary>
        long Count();




        /// <summary>
        /// Count using a filer
        /// </summary>
        /// <param name="where">Expression typeof TEntity</param>
        long Count(Expression<Func<TEntity, bool>> where);



        /// <summary>
        /// Count using a filer
        /// </summary>
        /// <param name="where">Expression typeof TEntity</param>
        void SaveEntity();
    }
}