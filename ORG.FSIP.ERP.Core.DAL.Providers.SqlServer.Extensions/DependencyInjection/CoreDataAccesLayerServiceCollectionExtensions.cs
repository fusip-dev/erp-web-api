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

            services.AddScoped<IRepository<CoreDataContext, Headquarter>, Repository<CoreDataContext, Headquarter>>();
            services.AddScoped<IRepository<CoreDataContext, Module>, Repository<CoreDataContext, Module>>();
            services.AddScoped<IRepository<CoreDataContext, Period>, Repository<CoreDataContext, Period>>();

            return services;

        }
    }
}
