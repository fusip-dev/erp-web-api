using Microsoft.EntityFrameworkCore;
using ORG.FSIP.ERP.Core.DAL.Entities;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer
{
    public partial class CoreDataContext : DbContext
    {
        public CoreDataContext() { }

        public CoreDataContext(DbContextOptions<CoreDataContext> options) : base(options) { }

        public virtual DbSet<Module> Modules { get; set; }

        public virtual DbSet<Resource> Resources { get; set; }

        public virtual DbSet<Headquarter> Headquarters { get; set; }

        public virtual DbSet<HeadquarterInformation> HeadquartersInformation { get; set; }

        public virtual DbSet<CustomFieldGroup> CustomFieldGroups { get; set; }

        public virtual DbSet<CustomField> CustomFields { get; set; }        

        public virtual DbSet<Period> Periods { get; set; }

        public virtual DbSet<PeriodState> PeriodStates { get; set; }   
    }
}
