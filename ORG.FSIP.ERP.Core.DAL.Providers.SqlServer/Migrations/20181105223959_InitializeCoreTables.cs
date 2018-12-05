using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.Migrations
{
    public partial class InitializeCoreTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "CustomFieldGroups",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    Entity = table.Column<string>(maxLength: 100, nullable: false),
                    CustomFieldGroupCode = table.Column<string>(maxLength: 30, nullable: false),
                    CustomFieldGroupName = table.Column<string>(maxLength: 100, nullable: false),
                    CustomFieldGroupDescription = table.Column<string>(maxLength: 255, nullable: true),
                    Order = table.Column<byte>(nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFieldGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Headquarters",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ParentHeadquarterId = table.Column<Guid>(nullable: true),
                    HeadquarterName = table.Column<string>(maxLength: 100, nullable: false),
                    HeadquarterCity = table.Column<string>(maxLength: 20, nullable: false),
                    HeadquarterAddress = table.Column<string>(maxLength: 255, nullable: true),
                    HeadquarterCode = table.Column<string>(maxLength: 10, nullable: false),
                    Acronym = table.Column<string>(maxLength: 15, nullable: false),
                    Order = table.Column<byte>(nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headquarters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Headquarters_ParentHeadquarter",
                        column: x => x.ParentHeadquarterId,
                        principalSchema: "dbo",
                        principalTable: "Headquarters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ModuleCode = table.Column<string>(maxLength: 50, nullable: false),
                    ModuleName = table.Column<string>(nullable: true),
                    ModuleDescription = table.Column<string>(maxLength: 255, nullable: true),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    Entity = table.Column<string>(maxLength: 255, nullable: false),
                    Reference = table.Column<Guid>(nullable: false),
                    MimeType = table.Column<string>(maxLength: 100, nullable: false),
                    Path = table.Column<string>(maxLength: 255, nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ParentSeasonId = table.Column<Guid>(nullable: true),
                    SeasonName = table.Column<string>(maxLength: 100, nullable: false),
                    SeasonStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SeasonEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_ParentSeason",
                        column: x => x.ParentSeasonId,
                        principalSchema: "dbo",
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomFields",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    CustomFieldGroupId = table.Column<Guid>(nullable: true),
                    Entity = table.Column<string>(maxLength: 100, nullable: false),
                    CustomFieldCode = table.Column<string>(maxLength: 30, nullable: false),
                    CustomFieldName = table.Column<string>(maxLength: 100, nullable: false),
                    CustomFieldType = table.Column<string>(maxLength: 50, nullable: false),
                    CustomFieldValidationRules = table.Column<string>(type: "text", nullable: true),
                    CustomFieldDefaultValue = table.Column<string>(type: "text", nullable: true, defaultValueSql: "('')"),
                    CustomFieldValues = table.Column<string>(type: "text", nullable: true, defaultValueSql: "('')"),
                    CustomFieldDescription = table.Column<string>(type: "text", maxLength: 255, nullable: true),
                    Order = table.Column<byte>(nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomFields_CustomFieldGroups",
                        column: x => x.CustomFieldGroupId,
                        principalSchema: "dbo",
                        principalTable: "CustomFieldGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeasonStates",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    State = table.Column<string>(nullable: false),
                    ModuleId = table.Column<Guid>(nullable: true),
                    HeadquarterId = table.Column<Guid>(nullable: true),
                    SeasonId = table.Column<Guid>(nullable: true),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeasonStates_Headquarters",
                        column: x => x.HeadquarterId,
                        principalSchema: "dbo",
                        principalTable: "Headquarters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeasonStates_Modules",
                        column: x => x.ModuleId,
                        principalSchema: "dbo",
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeasonStates_Seasons",
                        column: x => x.SeasonId,
                        principalSchema: "dbo",
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HeadquartersInformation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    HeadquarterId = table.Column<Guid>(nullable: true),
                    CustomFieldId = table.Column<Guid>(nullable: true),
                    Value = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadquartersInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeadquartersInformation_CustomFields",
                        column: x => x.CustomFieldId,
                        principalSchema: "dbo",
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeadquartersInformation_Headquarters",
                        column: x => x.HeadquarterId,
                        principalSchema: "dbo",
                        principalTable: "Headquarters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Headquarters",
                columns: new[] { "Id", "Acronym", "Created", "CreatedBy", "HeadquarterAddress", "HeadquarterCity", "HeadquarterCode", "HeadquarterName", "IsDelete", "Modified", "ModifiedBy", "Order", "ParentHeadquarterId", "Status" },
                values: new object[] { new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "", new DateTime(2017, 2, 8, 18, 40, 10, 147, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Direccion 0", "Cochabamba", "", "FUNDACION SIMON I. PATIÑO", false, new DateTime(2017, 2, 8, 18, 40, 10, 147, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)0, null, "1" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Modules",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDelete", "Modified", "ModifiedBy", "ModuleCode", "ModuleDescription", "ModuleName", "Status" },
                values: new object[,]
                {
                    { new Guid("5f8a2544-4ae1-e811-89d2-34e6d700b0a5"), new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), false, new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Accouting", "Module de Contabilidad", "Contabilidad", "AC" },
                    { new Guid("a735974a-4ae1-e811-89d2-34e6d700b0a5"), new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), false, new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "AssetManagement", "Modulo de Activos Fijos", "Activos Fijos", "AC" },
                    { new Guid("bc183658-4ae1-e811-89d2-34e6d700b0a5"), new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), false, new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "HumanResources", "Modulo de Recursos Humanos", "Recursos Humanos", "AC" },
                    { new Guid("9582b513-a970-e711-8983-8019341cdef0"), new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), false, new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Invoicing", "Modulo de Facturacion", "Facturacion", "AC" },
                    { new Guid("4b3ef764-4ae1-e811-89d2-34e6d700b0a5"), new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), false, new DateTime(2017, 2, 8, 18, 40, 10, 154, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Security", "Modulo de Seguridad", "Seguridad", "AC" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Headquarters",
                columns: new[] { "Id", "Acronym", "Created", "CreatedBy", "HeadquarterAddress", "HeadquarterCity", "HeadquarterCode", "HeadquarterName", "IsDelete", "Modified", "ModifiedBy", "Order", "ParentHeadquarterId", "Status" },
                values: new object[,]
                {
                    { new Guid("c0df7d8b-4fee-e611-8954-34e6d700b0a5"), "AUD", new DateTime(2017, 2, 8, 18, 40, 10, 148, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Direccion 1", "Cochabamba", "", "CENTRO AUDITORIA", false, new DateTime(2017, 2, 8, 18, 40, 10, 148, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)0, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "0" },
                    { new Guid("c1df7d8b-4fee-e611-8954-34e6d700b0a5"), "ARTYLITE", new DateTime(2017, 2, 8, 18, 40, 10, 148, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Direccion 2", "Cochabamba", "", "CENTRO DE DOCUMENTACION EN ARTE Y LITERATURA", false, new DateTime(2017, 2, 8, 18, 40, 10, 148, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)0, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "0" },
                    { new Guid("c2df7d8b-4fee-e611-8954-34e6d700b0a5"), "CSIP", new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Calle Independencia Nº 89", "Santa Cruz", "12", "CENTRO SIMÓN I. PATINO SANTA CRUZ", false, new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)10, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("c3df7d8b-4fee-e611-8954-34e6d700b0a5"), "CPAP", new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Calle Jordan Nº 0886 y Av. Oquendo", "Cochabamba", "01", "CENTRO DE PEDIATRIA ALBINA R. DE PATIÑO", false, new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)3, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("c4df7d8b-4fee-e611-8954-34e6d700b0a5"), "CPYCSIP", new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Av. Potosí N° 1450", "Cochabamba", "02", "CENTRO PEDAGÓGICO Y CULTURAL SIMÓN I. PATIÑO", false, new DateTime(2017, 2, 8, 18, 40, 10, 149, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)2, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("c5df7d8b-4fee-e611-8954-34e6d700b0a5"), "CEUSIP", new DateTime(2017, 2, 8, 18, 40, 10, 150, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Direccion 6", "Cochabamba", "", "CENTRO UNIVERSITARIO SIMON I. PATIÑO", false, new DateTime(2017, 2, 8, 18, 40, 10, 150, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)0, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "0" },
                    { new Guid("c6df7d8b-4fee-e611-8954-34e6d700b0a5"), "CEASIP", new DateTime(2017, 2, 8, 18, 40, 10, 150, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Palmar del Oratorio", "Santa Cruz", "05", "CENTRO DE ECOLOGÍA APLICADA", false, new DateTime(2017, 2, 8, 18, 40, 10, 150, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)8, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("c7df7d8b-4fee-e611-8954-34e6d700b0a5"), "ESIP", new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Avenida Ecuador N º 2503", "La Paz", "06", "ESPACIO SIMÓN I. PATIÑO", false, new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)9, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("c8df7d8b-4fee-e611-8954-34e6d700b0a5"), "FUSIP", new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Av. Potosí N° 1450", "Cochabamba", "07", "FUSIP", false, new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)1, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("c9df7d8b-4fee-e611-8954-34e6d700b0a5"), "GMP", new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Av. Simón I. Patiño Zona Vinto Pairumani", "Cochabamba", "09", "GRANJA MODELO PAIRUMANI", false, new DateTime(2017, 2, 8, 18, 40, 10, 151, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)7, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("cadf7d8b-4fee-e611-8954-34e6d700b0a5"), "FITO", new DateTime(2017, 2, 8, 18, 40, 10, 152, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Av. Simón I. Patiño Zona Vinto Pairumani", "Cochabamba", "10", "CENTRO FITOECOGENÉTICO", false, new DateTime(2017, 2, 8, 18, 40, 10, 152, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)5, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("cbdf7d8b-4fee-e611-8954-34e6d700b0a5"), "SEMILLAS", new DateTime(2017, 2, 8, 18, 40, 10, 152, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Av. Simón I. Patiño Zona Vinto Pairumani", "Cochabamba", "11", "CENTRO SEMILLAS", false, new DateTime(2017, 2, 8, 18, 40, 10, 152, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)6, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("ccdf7d8b-4fee-e611-8954-34e6d700b0a5"), "CEDSIP", new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Calle Independencia Nº 89 esq. Suarez de Figueroa", "Santa Cruz", "04", "CENTRO ECOPEDAGÓGICO SIMÓN I. PATIÑO", false, new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)4, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("cddf7d8b-4fee-e611-8954-34e6d700b0a5"), "CAPALTO", new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "Calle Jordan Nº 0886 y Av. Oquendo", "Cochabamba", "", "CENTRO DE NUTRICION INFANTIL ALBINA R. DE PATIÑO - EL ALTO", false, new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)11, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" },
                    { new Guid("cedf7d8b-4fee-e611-8954-34e6d700b0a5"), "CNICBBA", new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), "", "Cochabamba", "", "CENTRO DE NUTRICION INFANTIL ALBINA R. DE PATIÑO - COCHABAMBA", false, new DateTime(2017, 2, 8, 18, 40, 10, 153, DateTimeKind.Unspecified), new Guid("e9df7d8b-4fee-e611-8954-34e6d700b0a5"), (byte)12, new Guid("bfdf7d8b-4fee-e611-8954-34e6d700b0a5"), "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomFields_CustomFieldGroupId",
                schema: "dbo",
                table: "CustomFields",
                column: "CustomFieldGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Headquarters_ParentHeadquarterId",
                schema: "dbo",
                table: "Headquarters",
                column: "ParentHeadquarterId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadquartersInformation_CustomFieldId",
                schema: "dbo",
                table: "HeadquartersInformation",
                column: "CustomFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadquartersInformation_HeadquarterId",
                schema: "dbo",
                table: "HeadquartersInformation",
                column: "HeadquarterId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_ParentSeasonId",
                schema: "dbo",
                table: "Seasons",
                column: "ParentSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonStates_HeadquarterId",
                schema: "dbo",
                table: "SeasonStates",
                column: "HeadquarterId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonStates_ModuleId",
                schema: "dbo",
                table: "SeasonStates",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonStates_SeasonId",
                schema: "dbo",
                table: "SeasonStates",
                column: "SeasonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeadquartersInformation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Resources",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SeasonStates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomFields",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Headquarters",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Modules",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Seasons",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomFieldGroups",
                schema: "dbo");
        }
    }
}
