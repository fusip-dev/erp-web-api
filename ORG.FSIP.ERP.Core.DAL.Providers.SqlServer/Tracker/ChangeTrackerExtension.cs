using Microsoft.EntityFrameworkCore;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer
{
    public partial class CoreDataContext : DbContext
    {
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            TrackChanges();
            return base.SaveChangesAsync(cancellationToken);
        }

        private Guid UserProvider
        {
            get
            {
                return !string.IsNullOrEmpty(WindowsIdentity.GetCurrent().Name)
                    ? new Guid(WindowsIdentity.GetCurrent().Name.Split("\\")[1])
                    : Guid.Empty;
            }
        }

        private void TrackChanges()
        {
            foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                if (entry.Entity is IAuditable)
                {
                    var auditable = entry.Entity as IAuditable;
                    switch (entry.State)
                    {
                        case EntityState.Detached:
                        case EntityState.Unchanged:
                        case EntityState.Deleted:
                            break;
                        case EntityState.Modified:
                            auditable.ModifiedBy = UserProvider;
                            auditable.Modified = DateTime.UtcNow;
                            break;
                        case EntityState.Added:
                            auditable.CreatedBy = UserProvider;
                            auditable.ModifiedBy = UserProvider;
                            auditable.Created = DateTime.UtcNow;
                            auditable.Modified = DateTime.UtcNow;
                            break;
                    }
                }

            }
        }
    }
}
