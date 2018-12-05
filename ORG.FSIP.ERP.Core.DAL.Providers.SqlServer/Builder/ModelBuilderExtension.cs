using Microsoft.EntityFrameworkCore;
using ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.EntityTypeConfiguration;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer
{
    public partial class CoreDataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomFields());
            modelBuilder.ApplyConfiguration(new CustomFields());
            modelBuilder.ApplyConfiguration(new Headquarters());
            modelBuilder.ApplyConfiguration(new HeadquarterInformation());
            modelBuilder.ApplyConfiguration(new Modules());
            modelBuilder.ApplyConfiguration(new Resources());
            modelBuilder.ApplyConfiguration(new Periods());
            modelBuilder.ApplyConfiguration(new PeriodStates());
        }

    }
}
