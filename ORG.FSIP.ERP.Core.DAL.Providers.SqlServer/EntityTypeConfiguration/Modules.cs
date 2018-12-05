using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORG.FSIP.ERP.Core.DAL.Entities;
using System;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.EntityTypeConfiguration
{
    public class Modules : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            builder.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            #region seed data for modules
            builder.HasData(
                new Module
                {
                    Id = new Guid("5f8a2544-4ae1-e811-89d2-34e6d700b0a5"),
                    ModuleCode = "Accouting",
                    ModuleName = "Contabilidad",
                    ModuleDescription = "Module de Contabilidad",
                    Status = "AC",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")

                },
                new Module
                {
                    Id = new Guid("a735974a-4ae1-e811-89d2-34e6d700b0a5"),
                    ModuleCode = "AssetManagement",
                    ModuleName = "Activos Fijos",
                    ModuleDescription = "Modulo de Activos Fijos",
                    Status = "AC",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")

                },
                new Module
                {
                    Id = new Guid("bc183658-4ae1-e811-89d2-34e6d700b0a5"),
                    ModuleCode = "HumanResources",
                    ModuleName = "Recursos Humanos",
                    ModuleDescription = "Modulo de Recursos Humanos",
                    Status = "AC",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")

                },
                new Module
                {
                    Id = new Guid("9582b513-a970-e711-8983-8019341cdef0"),
                    ModuleCode = "Invoicing",
                    ModuleName = "Facturacion",
                    ModuleDescription = "Modulo de Facturacion",
                    Status = "AC",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")

                },
                new Module
                {
                    Id = new Guid("4b3ef764-4ae1-e811-89d2-34e6d700b0a5"),
                    ModuleCode = "Security",
                    ModuleName = "Seguridad",
                    ModuleDescription = "Modulo de Seguridad",
                    Status = "AC",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")

                }

            );
            #endregion
        }
    }
}
