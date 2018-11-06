using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ORG.FSIP.ERP.Core.DAL.Entities;
using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.Extensions.DependencyInjection
{
    public static class CoreDataAccesLayerServiceCollectionExtensions
    {
        public static IServiceCollection AddSqlServerDataProviderForCore(this IServiceCollection services, string stringConnection)
        {
            if(string.IsNullOrEmpty(stringConnection))
                throw new ArgumentNullException("stringConnection");

            services.AddDbContext<CoreDataContext>(options => options.UseSqlServer(stringConnection));

            services.AddScoped<DbContext, CoreDataContext>();

            services.AddSingleton<IGenericRepository<CoreDataContext, Headquarter>, GenericRepository<CoreDataContext, Headquarter>>();
            services.AddSingleton<IGenericRepository<CoreDataContext, Module>, GenericRepository<CoreDataContext, Module>>();
            services.AddSingleton<IGenericRepository<CoreDataContext, Season>, GenericRepository<CoreDataContext, Season>>();

            return services;

        }
    }
}
