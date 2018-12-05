using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORG.FSIP.ERP.Core.DAL.Entities;
using System;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.EntityTypeConfiguration
{
    public class Headquarters : IEntityTypeConfiguration<Headquarter>
    {
        public void Configure(EntityTypeBuilder<Headquarter> builder)
        {
            builder.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            builder.Property(e => e.Order).HasDefaultValueSql("((0))");

            builder.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            #region seed data for headquarter

            builder.HasData(
                new
                {
                    Id = new Guid("BFDF7D8B-4FEE-E611-8954-34E6D700B0A5"),
                    HeadquarterName = "FUNDACION SIMON I. PATIÑO",
                    HeadquarterCity = "Cochabamba",
                    HeadquarterMainAddress = "Direccion 0",
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
                    HeadquarterMainAddress = "Direccion 1",
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
                    HeadquarterMainAddress = "Direccion 2",
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
                    HeadquarterMainAddress = "Calle Independencia Nº 89",
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
                    HeadquarterMainAddress = "Calle Jordan Nº 0886 y Av. Oquendo",
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
                    HeadquarterMainAddress = "Av. Potosí N° 1450",
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
                    HeadquarterMainAddress = "Direccion 6",
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
                    HeadquarterMainAddress = "Palmar del Oratorio",
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
                    HeadquarterMainAddress = "Avenida Ecuador N º 2503",
                    HeadquarterCode = "06",
                    Acronym = "ESIP",
                    Order = (byte)9,
                    Status = "1",
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
                    HeadquarterMainAddress = "Av. Potosí N° 1450",
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
                    HeadquarterMainAddress = "Av. Simón I. Patiño Zona Vinto Pairumani",
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
                    HeadquarterMainAddress = "Av. Simón I. Patiño Zona Vinto Pairumani",
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
                    HeadquarterMainAddress = "Av. Simón I. Patiño Zona Vinto Pairumani",
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
                    HeadquarterMainAddress = "Calle Independencia Nº 89 esq. Suarez de Figueroa",
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
                    HeadquarterMainAddress = "Calle Jordan Nº 0886 y Av. Oquendo",
                    HeadquarterCode = string.Empty,
                    Acronym = "CNIALTO",
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
                    HeadquarterMainAddress = string.Empty,
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
        }
    }
}
