using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ORG.FSIP.ERP.Core.DAL.Infraestructure
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// Gets a collection of all objects in the database
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <returns>An ICollection of every object in the database</returns>
        ICollection<TEntity> All();

        /// <summary>
        /// Gets a collection of all objects in the database
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <returns>An ICollection of every object in the database</returns>
        Task<ICollection<TEntity>> AllAsync();

        /// <summary>
        /// Returns a single object which matches the id
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="id">Entity ID to find a single object</param>
        /// <returns>A single object which matches the id. 
        /// If not are found any object, null is returned</returns>
        TEntity Get(object id);

        /// <summary>
        /// Returns a single object which matches the id
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="id">Entity ID to find a single object</param>
        /// <returns>A single object which matches the id. 
        /// Iif not are found any object, null is returned</returns>
        Task<TEntity> GetAsync(object id);

        /// <summary>
        /// Returns a single object which matches the provided expression
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">A Linq expression filter to find a single result</param>
        /// <returns>A single object which matches the expression filter. 
        /// If more than one object is found or if zero are found, null is returned</returns>
        TEntity Find(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Returns a single object which matches the provided expression
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="match">A Linq expression filter to find a single result</param>
        /// <returns>A single object which matches the expression filter. 
        /// If more than one object is found or if zero are found, null is returned</returns>
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Returns a collection of objects which match the provided expression
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">A linq expression filter to find one or more results</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Returns a collection of objects which match the provided expression
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="filter">A linq expression filter to find one or more results</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Returns a collection paged of objects which match the provided expression and order by sort parameters
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">A linq expression filter to find one or more results</param
        /// <param name="sort"> A dictionary with sort parameters.</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> filter, IEnumerable<string> sort);

        /// <summary>
        /// Returns a collection paged of objects which match the provided expression and order by sort parameters
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="filter">A linq expression filter to find one or more results</param
        /// <param name="sort"> A dictionary with sort parameters.</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> filter, IEnumerable<string> sort);

        /// <summary>
        /// Inserts a single object to the database and commits the change
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="entity">The object to insert</param>
        /// <returns>The resulting object including its primary key after the insert</returns>
        TEntity Add(TEntity entity);

        /// <summary>
        /// Inserts a single object to the database and commits the change
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="entity">The object to insert</param>
        /// <returns>The resulting object including its primary key after the insert</returns>
        Task<TEntity> AddAsync(TEntity entity);

        /// <summary>
        /// Inserts a collection of objects into the database and commits the changes
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="entities">An IEnumerable list of objects to insert</param>
        /// <returns>The IEnumerable resulting list of inserted objects including the primary keys</returns>
        IEnumerable<TEntity> AddAll(IEnumerable<TEntity> entities);

        /// <summary>
        /// Inserts a collection of objects into the database and commits the changes
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="entities">An IEnumerable list of objects to insert</param>
        /// <returns>The IEnumerable resulting list of inserted objects including the primary keys</returns>
        Task<IEnumerable<TEntity>> AddAllAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Updates a single object based on the provided primary key and commits the change
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="updated">The updated object to apply to the database</param>
        /// <param name="key">The primary key of the object to update</param>
        /// <returns>The resulting updated object</returns>
        TEntity Update(TEntity updated, object key);

        /// <summary>
        /// Updates a single object based on the provided primary key and commits the change
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="updated">The updated object to apply to the database</param>
        /// <param name="key">The primary key of the object to update</param>
        /// <returns>The resulting updated object</returns>
        Task<TEntity> UpdateAsync(TEntity updated, object key);

        /// <summary>
        /// Deletes a single object from the database and commits the change
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="entity">The object to delete</param>
        int Delete(TEntity entity);

        /// <summary>
        /// Deletes a single object from the database and commits the change
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="entity">The object to delete</param>
        Task<int> DeleteAsync(TEntity entity);

        /// <summary>
        /// Delete objects from database by specified filter expression.
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">A linq expression filter to delete one or more objects</param>
        /// <returns>The number of state entries written to the underlying database. 
        /// This can include state entries for entities and/or relationships. Relationship 
        /// state entries are created for many-to-many relationships and relationships where
        /// there is no foreign key property included in the entity class (often referred to 
        /// as independent associations).</returns>
        int DeleteAll(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Delete objects from database by specified filter expression.
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">A linq expression filter to delete one or more objects</param>
        /// <returns>The number of state entries written to the underlying database. 
        /// This can include state entries for entities and/or relationships. Relationship 
        /// state entries are created for many-to-many relationships and relationships where
        /// there is no foreign key property included in the entity class (often referred to 
        /// as independent associations).</returns>
        Task<int> DeleteAllAsync(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Gets the count of the number of objects in the databse
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <returns>The count of the number of objects</returns>
        int Count();

        /// <summary>
        /// Gets the count of the number of objects in the databse
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <returns>The count of the number of objects</returns>
        Task<int> CountAsync();

        /// <summary>
        /// Gets the object(s) is exists in database by specified filter.
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">Specified the filter expression</param>
        /// <returns>If the database contains the object that matches the provided expression, 
        /// True is returned, false otherwise </returns>
        bool Contains(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Gets the object(s) is exists in database by specified filter.
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="filter">Specified the filter expression</param>
        /// <returns>If the database contains the object that matches the provided expression, 
        /// True is returned, false otherwise </returns>
        Task<bool> ContainsAsync(Expression<Func<TEntity, bool>> filter);
    }
}
