using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Infraestructure
{
    public interface IGenericRepository<TDbContext, TEntity>: IRepository<TEntity>
        where TDbContext : DbContext
        where TEntity : IEntity
    {
        TDbContext _context { get; }
    }
}
