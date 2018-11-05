using Microsoft.EntityFrameworkCore;
using ORG.FSIP.ERP.Core.DAL.Entities;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer
{
    public class CoreDataContext : DbContext
    {
        public CoreDataContext() { }

        public CoreDataContext(DbContextOptions<CoreDataContext> options) : base(options) { }

        public DbSet<Module> Modules { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Headquarter> Headquarters { get; set; }

        public virtual DbSet<HeadquarterInformation> HeadquartersInformation { get; set; }

        public virtual DbSet<CustomFieldGroup> CustomFieldGroups { get; set; }

        public virtual DbSet<CustomField> CustomFields { get; set; }        

        public virtual DbSet<Season> Seasons { get; set; }

        public virtual DbSet<SeasonState> SeasonStates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomFieldGroup>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomField>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CustomFieldDefaultValue).HasDefaultValueSql("('')");

                entity.Property(e => e.CustomFieldValues).HasDefaultValueSql("('')");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HeadquarterInformation>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Headquarter>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");                

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");
            });

            #region seed data for headquarter

            modelBuilder.Entity<Headquarter>().HasData(
                new {
                    Id = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "FUNDACION SIMON I. PATIÑO",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Direccion 0",
                    HeadquarterCode = string.Empty,
                    Acronym = string.Empty,
                    Order = (byte)0,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 147),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 147),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new 
                {
                    Id = new Guid("C0DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO AUDITORIA",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Direccion 1",
                    HeadquarterCode = string.Empty,
                    Acronym = "AUD",
                    Order = (byte)0,
                    Status = "0",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 148),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 148),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new 
                {
                    Id = new Guid("C1DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO DE DOCUMENTACION EN ARTE Y LITERATURA",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Direccion 2",
                    HeadquarterCode = string.Empty,
                    Acronym = "ARTYLITE",
                    Order = (byte)0,
                    Status = "0",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 148),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 148),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("C2DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO SIMÓN I. PATINO SANTA CRUZ",
                    HeadquarterCity = "Santa Cruz",
                    HeadquarterAddress = "Calle Independencia Nº 89",
                    HeadquarterCode = "12",
                    Acronym = "CSIP",
                    Order = (byte)10,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 149),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 149),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new 
                {
                    Id = new Guid("C3DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO DE PEDIATRIA ALBINA R. DE PATIÑO",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Calle Jordan Nº 0886 y Av. Oquendo",
                    HeadquarterCode = "01",
                    Acronym = "CPAP",
                    Order = (byte)3,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 149),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 149),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("C4DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO PEDAGÓGICO Y CULTURAL SIMÓN I. PATIÑO",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Av. Potosí N° 1450",
                    HeadquarterCode = "02",
                    Acronym = "CPYCSIP",
                    Order = (byte)2,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 149),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 149),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("C5DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO UNIVERSITARIO SIMON I. PATIÑO",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Direccion 6",
                    HeadquarterCode = string.Empty,
                    Acronym = "CEUSIP",
                    Order = (byte)0,
                    Status = "0",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 150),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 150),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("C6DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO DE ECOLOGÍA APLICADA",
                    HeadquarterCity = "Santa Cruz",
                    HeadquarterAddress = "Palmar del Oratorio",
                    HeadquarterCode = "05",
                    Acronym = "CEASIP",
                    Order = (byte)8,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 150),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 150),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("C7DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "ESPACIO SIMÓN I. PATIÑO",
                    HeadquarterCity = "La Paz",
                    HeadquarterAddress = "Avenida Ecuador N º 2503",
                    HeadquarterCode = "06",
                    Acronym = "ESIP",
                    Order = (byte)0,
                    Status = "9",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 151),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 151),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("C8DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "FUSIP",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Av. Potosí N° 1450",
                    HeadquarterCode = "07",
                    Acronym = "FUSIP",
                    Order = (byte)1,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 151),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 151),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("C9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "GRANJA MODELO PAIRUMANI",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Av. Simón I. Patiño Zona Vinto Pairumani",
                    HeadquarterCode = "09",
                    Acronym = "GMP",
                    Order = (byte)7,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 151),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 151),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("CADF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO FITOECOGENÉTICO",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Av. Simón I. Patiño Zona Vinto Pairumani",
                    HeadquarterCode = "10",
                    Acronym = "FITO",
                    Order = (byte)5,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 152),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 152),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("CBDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO SEMILLAS",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Av. Simón I. Patiño Zona Vinto Pairumani",
                    HeadquarterCode = "11",
                    Acronym = "SEMILLAS",
                    Order = (byte)6,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 152),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 152),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new
                {
                    Id = new Guid("CCDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO ECOPEDAGÓGICO SIMÓN I. PATIÑO",
                    HeadquarterCity = "Santa Cruz",
                    HeadquarterAddress = "Calle Independencia Nº 89 esq. Suarez de Figueroa",
                    HeadquarterCode = "04",
                    Acronym = "CEDSIP",
                    Order = (byte)4,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 153),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 153),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new 
                {
                    Id = new Guid("CDDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO DE NUTRICION INFANTIL ALBINA R. DE PATIÑO - EL ALTO",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = "Calle Jordan Nº 0886 y Av. Oquendo",
                    HeadquarterCode = string.Empty,
                    Acronym = "CAPALTO",
                    Order = (byte)11,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 153),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 153),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                },
                new 
                {
                    Id = new Guid("CEDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    ParentHeadquarterId = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "CENTRO DE NUTRICION INFANTIL ALBINA R. DE PATIÑO - COCHABAMBA",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterAddress = string.Empty,
                    HeadquarterCode = string.Empty,
                    Acronym = "CNICBBA",
                    Order = (byte)12,
                    Status = "1",
                    IsDelete = false,
                    Created = new DateTime(2017, 2, 8, 18, 40, 10, 153),
                    CreatedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    Modified = new DateTime(2017, 2, 8, 18, 40, 10, 153),
                    ModifiedBy = new Guid("E9DF7D8B-4FEE-E611-8954-34E6D700B0A5")
                }
            );
            #endregion

            modelBuilder.Entity<Module>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");
            });

            #region seed data for modules
            modelBuilder.Entity<Module>().HasData(
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

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SeasonState>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");
            });
        }

        public Guid UserProvider
        {
            get
            {
                return !string.IsNullOrEmpty(WindowsIdentity.GetCurrent().Name)
                    ? new Guid(WindowsIdentity.GetCurrent().Name.Split("\\")[1])
                    : Guid.Empty;
            }
        }

        public Func<DateTime> TimestampProvider { get; set; } = () => DateTime.UtcNow;

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            TrackChanges();
            return base.SaveChangesAsync(cancellationToken);
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
                            auditable.Modified = TimestampProvider();
                            break;
                        case EntityState.Added:
                            auditable.CreatedBy = UserProvider;
                            auditable.ModifiedBy = UserProvider;
                            auditable.Created = TimestampProvider();
                            auditable.Modified = TimestampProvider();
                            break;
                    }
                }

            }
        }
    }
}
