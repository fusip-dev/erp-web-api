using Microsoft.EntityFrameworkCore;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using ORG.FSIP.ERP.Libraries.ExpressionBuilder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ORG.FSIP.ERP.Core.DAL.Generic
{
    public class GenericRepository<TDbContext, TEntity> : IGenericRepository<TDbContext, TEntity>
        where TDbContext : DbContext
        where TEntity : Entity
    {
        public TDbContext _context { get; private set; }

        private bool disposed = false;

        public GenericRepository(TDbContext context)
        {
            _context = context;
            _context.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        /// <summary>
        /// Gets a collection of all objects in the database
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <returns>An ICollection of every object in the database</returns>
        public virtual ICollection<TEntity> All()
        {

            return _context.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Gets a collection of all objects in the database
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <returns>An ICollection of every object in the database</returns>
        public virtual async Task<ICollection<TEntity>> AllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        /// <summary>
        /// Returns a single object which matches the id
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="id">Entity ID to find a single object</param>
        /// <returns>A single object which matches the id. 
        /// If not are found any object, null is returned</returns>
        public virtual TEntity Get(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Returns a single object which matches the id
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="id">Entity ID to find a single object</param>
        /// <returns>A single object which matches the id. 
        /// Iif not are found any object, null is returned</returns>
        public virtual async Task<TEntity> GetAsync(object id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        /// <summary>
        /// Returns a single object which matches the provided expression
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">A Linq expression filter to find a single result</param>
        /// <returns>A single object which matches the expression filter. 
        /// If more than one object is found or if zero are found, null is returned</returns>
        public virtual TEntity Find(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().FirstOrDefault(filter);
        }


        /// <summary>
        /// Returns a single object which matches the provided expression
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="match">A Linq expression filter to find a single result</param>
        /// <returns>A single object which matches the expression filter. 
        /// If more than one object is found or if zero are found, null is returned</returns>
        public virtual async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        /// <summary>
        /// Returns a collection of objects which match the provided expression
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">A linq expression filter to find one or more results</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        public virtual ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter).ToList();
        }

        /// <summary>
        /// Returns a collection of objects which match the provided expression
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="filter">A linq expression filter to find one or more results</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        public virtual async Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().Where(filter).ToListAsync();
        }

        /// <summary>
        /// Returns a collection paged of objects which match the provided expression and order by sort parameters
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">A linq expression filter to find one or more results</param
        /// <param name="sort"> A dictionary with sort parameters.</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        public ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> filter, IEnumerable<string> sort)
        {
            var data = filter != null
                ? _context.Set<TEntity>().Where(filter).AsQueryable()
                : _context.Set<TEntity>().AsQueryable();

            return sort != null ? data.OrderByProperties(sort).ToList() : data.ToList();
        }

        /// <summary>
        /// Returns a collection paged of objects which match the provided expression and order by sort parameters
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="filter">A linq expression filter to find one or more results</param
        /// <param name="sort"> A dictionary with sort parameters.</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        public async Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> filter, IEnumerable<string> sort)
        {
            var data = filter != null
                ? _context.Set<TEntity>().Where(filter).AsQueryable()
                : _context.Set<TEntity>().AsQueryable();

            return await (sort != null ? data.OrderByProperties(sort).ToListAsync() : data.ToListAsync());
        }

        /// <summary>
        /// Inserts a single object to the database and commits the change
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="entity">The object to insert</param>
        /// <returns>The resulting object including its primary key after the insert</returns>
        public virtual TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        /// <summary>
        /// Inserts a single object to the database and commits the change
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="entity">The object to insert</param>
        /// <returns>The resulting object including its primary key after the insert</returns>
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Inserts a collection of objects into the database and commits the changes
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="entities">An IEnumerable list of objects to insert</param>
        /// <returns>The IEnumerable resulting list of inserted objects including the primary keys</returns>
        public virtual IEnumerable<TEntity> AddAll(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            _context.SaveChanges();
            return entities;
        }

        /// <summary>
        /// Inserts a collection of objects into the database and commits the changes
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="entities">An IEnumerable list of objects to insert</param>
        /// <returns>The IEnumerable resulting list of inserted objects including the primary keys</returns>
        public virtual async Task<IEnumerable<TEntity>> AddAllAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        /// <summary>
        /// Updates a single object based on the provided primary key and commits the change
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="updated">The updated object to apply to the database</param>
        /// <param name="key">The primary key of the object to update</param>
        /// <returns>The resulting updated object</returns>
        public virtual TEntity Update(TEntity updated, object key)
        {
            if (updated == null)
                return null;

            TEntity existing = _context.Set<TEntity>().Find(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                _context.SaveChanges();
            }
            return existing;
        }

        /// <summary>
        /// Updates a single object based on the provided primary key and commits the change
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="updated">The updated object to apply to the database</param>
        /// <param name="key">The primary key of the object to update</param>
        /// <returns>The resulting updated object</returns>
        public virtual async Task<TEntity> UpdateAsync(TEntity updated, object key)
        {
            if (updated == null)
                return null;

            TEntity existing = await _context.Set<TEntity>().FindAsync(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                await _context.SaveChangesAsync();
            }
            return existing;
        }

        /// <summary>
        /// Deletes a single object from the database and commits the change
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="entity">The object to delete</param>
        public int Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChanges();
        }

        /// <summary>
        /// Deletes a single object from the database and commits the change
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="entity">The object to delete</param>
        public async Task<int> DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

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
        public int DeleteAll(Expression<Func<TEntity, bool>> filter)
        {
            var objects = FindAll(filter);
            foreach (var obj in objects)
                _context.Set<TEntity>().Remove(obj);
            return _context.SaveChanges();
        }

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
        public async Task<int> DeleteAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            var objects = FindAll(filter);
            foreach (var obj in objects)
                _context.Set<TEntity>().Remove(obj);

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the count of the number of objects in the databse
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <returns>The count of the number of objects</returns>
        public int Count()
        {
            return _context.Set<TEntity>().Count();
        }

        /// <summary>
        /// Gets the count of the number of objects in the databse
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <returns>The count of the number of objects</returns>
        public async Task<int> CountAsync()
        {
            return await _context.Set<TEntity>().CountAsync();
        }

        /// <summary>
        /// Gets the object(s) is exists in database by specified filter.
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="filter">Specified the filter expression</param>
        /// <returns>If the database contains the object that matches the provided expression, 
        /// True is returned, false otherwise </returns>
        public bool Contains(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Count<TEntity>(filter) > 0;
        }

        /// <summary>
        /// Gets the object(s) is exists in database by specified filter.
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="filter">Specified the filter expression</param>
        /// <returns>If the database contains the object that matches the provided expression, 
        /// True is returned, false otherwise </returns>
        public async Task<bool> ContainsAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().CountAsync(filter) > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
