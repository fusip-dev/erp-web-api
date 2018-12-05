﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORG.FSIP.ERP.Core.DAL.Providers.SqlServer;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.Migrations
{
    [DbContext(typeof(CoreDataContext))]
    partial class CoreDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.CustomField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("CreatedBy");

                    b.Property<string>("CustomFieldCode")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("CustomFieldDefaultValue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("CustomFieldDescription")
                        .HasColumnType("text")
                        .HasMaxLength(255);

                    b.Property<Guid>("CustomFieldGroupId");

                    b.Property<string>("CustomFieldName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CustomFieldType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CustomFieldValidationRules")
                        .HasColumnType("text");

                    b.Property<string>("CustomFieldValues");

                    b.Property<string>("Entity")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<byte>("Order");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldGroupId");

                    b.ToTable("CustomFields");
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.CustomFieldGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<Guid>("CreatedBy");

                    b.Property<string>("CustomFieldGroupCode")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("CustomFieldGroupDescription")
                        .HasMaxLength(255);

                    b.Property<string>("CustomFieldGroupName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Entity")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("Modified");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<byte>("Order");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("CustomFieldGroups");
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.Headquarter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<string>("Acronym")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("CreatedBy");

                    b.Property<string>("HeadquarterCity")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("HeadquarterCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("HeadquarterMainAddress")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("HeadquarterName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<byte>("Order")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<Guid?>("ParentHeadquarterId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("ParentHeadquarterId");

                    b.ToTable("Headquarters");

                    b.HasData(
                        new { Id = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "", Created = new DateTime(2017, 2, 8, 18, 40, 10, 147, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "", HeadquarterMainAddress = "Direccion 0", HeadquarterName = "FUNDACION SIMON I. PATIÑO", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 147, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)0, Status = "1" },
                        new { Id = new Guid("c0df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "AUD", Created = new DateTime(2017, 2, 8, 18, 40, 10, 148, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "", HeadquarterMainAddress = "Direccion 1", HeadquarterName = "CENTRO AUDITORIA", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 148, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)0, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "0" },
                        new { Id = new Guid("c1df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "ARTYLITE", Created = new DateTime(2017, 2, 8, 18, 40, 10, 148, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "", HeadquarterMainAddress = "Direccion 2", HeadquarterName = "CENTRO DE DOCUMENTACION EN ARTE Y LITERATURA", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 148, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)0, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "0" },
                        new { Id = new Guid("c2df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "CSIP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Santa Cruz", HeadquarterCode = "12", HeadquarterMainAddress = "Calle Independencia Nº 89", HeadquarterName = "CENTRO SIMÓN I. PATINO SANTA CRUZ", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)10, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("c3df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "CPAP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "01", HeadquarterMainAddress = "Calle Jordan Nº 0886 y Av. Oquendo", HeadquarterName = "CENTRO DE PEDIATRIA ALBINA R. DE PATIÑO", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)3, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("c4df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "CPYCSIP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "02", HeadquarterMainAddress = "Av. Potosí N° 1450", HeadquarterName = "CENTRO PEDAGÓGICO Y CULTURAL SIMÓN I. PATIÑO", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)2, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("c5df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "CEUSIP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 150, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "", HeadquarterMainAddress = "Direccion 6", HeadquarterName = "CENTRO UNIVERSITARIO SIMON I. PATIÑO", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 150, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)0, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "0" },
                        new { Id = new Guid("c6df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "CEASIP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 150, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Santa Cruz", HeadquarterCode = "05", HeadquarterMainAddress = "Palmar del Oratorio", HeadquarterName = "CENTRO DE ECOLOGÍA APLICADA", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 150, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)8, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("c7df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "ESIP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "La Paz", HeadquarterCode = "06", HeadquarterMainAddress = "Avenida Ecuador N º 2503", HeadquarterName = "ESPACIO SIMÓN I. PATIÑO", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)0, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "9" },
                        new { Id = new Guid("c8df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "FUSIP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "07", HeadquarterMainAddress = "Av. Potosí N° 1450", HeadquarterName = "FUSIP", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)1, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("c9df7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "GMP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "09", HeadquarterMainAddress = "Av. Simón I. Patiño Zona Vinto Pairumani", HeadquarterName = "GRANJA MODELO PAIRUMANI", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)7, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("cadf7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "FITO", Created = new DateTime(2017, 2, 8, 18, 40, 10, 152, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "10", HeadquarterMainAddress = "Av. Simón I. Patiño Zona Vinto Pairumani", HeadquarterName = "CENTRO FITOECOGENÉTICO", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 152, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)5, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("cbdf7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "SEMILLAS", Created = new DateTime(2017, 2, 8, 18, 40, 10, 152, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "11", HeadquarterMainAddress = "Av. Simón I. Patiño Zona Vinto Pairumani", HeadquarterName = "CENTRO SEMILLAS", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 152, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)6, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("ccdf7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "CEDSIP", Created = new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Santa Cruz", HeadquarterCode = "04", HeadquarterMainAddress = "Calle Independencia Nº 89 esq. Suarez de Figueroa", HeadquarterName = "CENTRO ECOPEDAGÓGICO SIMÓN I. PATIÑO", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)4, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("cddf7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "CNIALTO", Created = new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "", HeadquarterMainAddress = "Calle Jordan Nº 0886 y Av. Oquendo", HeadquarterName = "CENTRO DE NUTRICION INFANTIL ALBINA R. DE PATIÑO - EL ALTO", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)11, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" },
                        new { Id = new Guid("cedf7d8b-4fee-e611-8954-34e6d700b0a5"), Acronym = "CNICBBA", Created = new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), HeadquarterCity = "Cochabamba", HeadquarterCode = "", HeadquarterMainAddress = "", HeadquarterName = "CENTRO DE NUTRICION INFANTIL ALBINA R. DE PATIÑO - COCHABAMBA", IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), Order = (byte)12, ParentHeadquarterId = new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), Status = "1" }
                    );
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.HeadquarterInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("CreatedBy");

                    b.Property<Guid>("CustomFieldId");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("HeadquarterId");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldId");

                    b.HasIndex("HeadquarterId");

                    b.ToTable("HeadquartersInformation");
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.Module", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("CreatedBy");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<string>("ModuleCode")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ModuleDescription")
                        .HasMaxLength(255);

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Modules");

                    b.HasData(
                        new { Id = new Guid("5f8a2544-4ae1-e811-89d2-34e6d700b0a5"), Created = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), ModuleCode = "Accouting", ModuleDescription = "Module de Contabilidad", ModuleName = "Contabilidad", Status = "AC" },
                        new { Id = new Guid("a735974a-4ae1-e811-89d2-34e6d700b0a5"), Created = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), ModuleCode = "AssetManagement", ModuleDescription = "Modulo de Activos Fijos", ModuleName = "Activos Fijos", Status = "AC" },
                        new { Id = new Guid("bc183658-4ae1-e811-89d2-34e6d700b0a5"), Created = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), ModuleCode = "HumanResources", ModuleDescription = "Modulo de Recursos Humanos", ModuleName = "Recursos Humanos", Status = "AC" },
                        new { Id = new Guid("9582b513-a970-e711-8983-8019341cdef0"), Created = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), ModuleCode = "Invoicing", ModuleDescription = "Modulo de Facturacion", ModuleName = "Facturacion", Status = "AC" },
                        new { Id = new Guid("4b3ef764-4ae1-e811-89d2-34e6d700b0a5"), Created = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), CreatedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), IsDelete = false, Modified = new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), ModifiedBy = new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), ModuleCode = "Security", ModuleDescription = "Modulo de Seguridad", ModuleName = "Seguridad", Status = "AC" }
                    );
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.Period", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("CreatedBy");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<Guid?>("ParentPeriodId");

                    b.Property<DateTime?>("PeriodEndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PeriodName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("PeriodStartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("ParentPeriodId");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.PeriodState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("CreatedBy");

                    b.Property<Guid>("HeadquarterId");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<Guid>("ModuleId");

                    b.Property<Guid>("PeriodId");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("HeadquarterId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("PeriodId");

                    b.ToTable("PeriodStates");
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("CreatedBy");

                    b.Property<string>("Entity")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsDelete");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<Guid>("Reference");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.CustomField", b =>
                {
                    b.HasOne("ORG.FSIP.ERP.Core.DAL.Entities.CustomFieldGroup", "CustomFieldGroup")
                        .WithMany("CustomFields")
                        .HasForeignKey("CustomFieldGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.Headquarter", b =>
                {
                    b.HasOne("ORG.FSIP.ERP.Core.DAL.Entities.Headquarter", "ParentHeadquarter")
                        .WithMany("SubHeadquarters")
                        .HasForeignKey("ParentHeadquarterId");
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.HeadquarterInformation", b =>
                {
                    b.HasOne("ORG.FSIP.ERP.Core.DAL.Entities.CustomField", "CustomField")
                        .WithMany("HeadquarterAdditionalInformation")
                        .HasForeignKey("CustomFieldId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ORG.FSIP.ERP.Core.DAL.Entities.Headquarter", "Headquarter")
                        .WithMany("HeadquarterInformation")
                        .HasForeignKey("HeadquarterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.Period", b =>
                {
                    b.HasOne("ORG.FSIP.ERP.Core.DAL.Entities.Period", "ParentPeriod")
                        .WithMany("Periods")
                        .HasForeignKey("ParentPeriodId");
                });

            modelBuilder.Entity("ORG.FSIP.ERP.Core.DAL.Entities.PeriodState", b =>
                {
                    b.HasOne("ORG.FSIP.ERP.Core.DAL.Entities.Headquarter", "Headquarter")
                        .WithMany("PeriodStatus")
                        .HasForeignKey("HeadquarterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ORG.FSIP.ERP.Core.DAL.Entities.Module", "Module")
                        .WithMany("PeriodStates")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ORG.FSIP.ERP.Core.DAL.Entities.Period", "Period")
                        .WithMany("PeriodStates")
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
