using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

            return services;

        }
    }
}
