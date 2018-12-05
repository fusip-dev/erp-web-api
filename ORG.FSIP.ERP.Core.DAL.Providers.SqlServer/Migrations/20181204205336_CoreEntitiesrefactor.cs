using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.Migrations
{
    public partial class CoreEntitiesrefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomFieldGroups",
                schema: "dbo",
                table: "CustomFields");

            migrationBuilder.DropForeignKey(
                name: "FK_HeadquartersInformation_CustomFields",
                schema: "dbo",
                table: "HeadquartersInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_HeadquartersInformation_Headquarters",
                schema: "dbo",
                table: "HeadquartersInformation");

            migrationBuilder.DropTable(
                name: "SeasonStates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Seasons",
                schema: "dbo");

            migrationBuilder.RenameColumn(
                name: "HeadquarterAddress",
                newName : "HeadquarterMainAddress",
                schema: "dbo",
                table: "Headquarters");

            migrationBuilder.RenameTable(
                name: "Resources",
                schema: "dbo",
                newName: "Resources");

            migrationBuilder.RenameTable(
                name: "Modules",
                schema: "dbo",
                newName: "Modules");

            migrationBuilder.RenameTable(
                name: "HeadquartersInformation",
                schema: "dbo",
                newName: "HeadquartersInformation");

            migrationBuilder.RenameTable(
                name: "Headquarters",
                schema: "dbo",
                newName: "Headquarters");

            migrationBuilder.RenameTable(
                name: "CustomFields",
                schema: "dbo",
                newName: "CustomFields");

            migrationBuilder.RenameTable(
                name: "CustomFieldGroups",
                schema: "dbo",
                newName: "CustomFieldGroups");

            migrationBuilder.AlterColumn<string>(
                name: "Entity",
                table: "Resources",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ModuleName",
                table: "Modules",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "HeadquarterId",
                table: "HeadquartersInformation",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomFieldId",
                table: "HeadquartersInformation",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Order",
                table: "Headquarters",
                nullable: false,
                defaultValueSql: "((0))",
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "HeadquarterCity",
                table: "Headquarters",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CustomFieldValues",
                table: "CustomFields",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldDefaultValueSql: "('')");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomFieldGroupId",
                table: "CustomFields",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "CustomFieldGroups",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "CustomFieldGroups",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "CustomFieldGroups",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newsequentialid())");

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ParentPeriodId = table.Column<Guid>(nullable: true),
                    PeriodName = table.Column<string>(maxLength: 100, nullable: false),
                    PeriodStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PeriodEndDate = table.Column<DateTime>(type: "datetime", nullable: true),                    
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Periods_ParentPeriod",
                        column: x => x.ParentPeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PeriodStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    PeriodId = table.Column<Guid>(nullable: false),
                    HeadquarterId = table.Column<Guid>(nullable: false),
                    ModuleId = table.Column<Guid>(nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodStates_Headquarters",
                        column: x => x.HeadquarterId,
                        principalTable: "Headquarters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriodStates_Modules",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriodStates_Periods",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: new Guid("cddf7d8b-4fee-e611-8954-34e6d700b0a5"),
                column: "Acronym" ,
                value:  "CNIALTO");

            migrationBuilder.CreateIndex(
                name: "IX_Periods_ParentPeriodId",
                table: "Periods",
                column: "ParentPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodStates_HeadquarterId",
                table: "PeriodStates",
                column: "HeadquarterId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodStates_ModuleId",
                table: "PeriodStates",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodStates_PeriodId",
                table: "PeriodStates",
                column: "PeriodId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomFieldGroups",
                table: "CustomFields",
                column: "CustomFieldGroupId",
                principalTable: "CustomFieldGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeadquartersInformation_CustomFields",
                table: "HeadquartersInformation",
                column: "CustomFieldId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeadquartersInformation_Headquarters",
                table: "HeadquartersInformation",
                column: "HeadquarterId",
                principalTable: "Headquarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomFieldGroups",
                table: "CustomFields");

            migrationBuilder.DropForeignKey(
                name: "FK_HeadquartersInformation_CustomFields",
                table: "HeadquartersInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_HeadquartersInformation_Headquarters",
                table: "HeadquartersInformation");

            migrationBuilder.DropTable(
                name: "PeriodStates");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Resources",
                newName: "Resources",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "Modules",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "HeadquartersInformation",
                newName: "HeadquartersInformation",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Headquarters",
                newName: "Headquarters",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CustomFields",
                newName: "CustomFields",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CustomFieldGroups",
                newName: "CustomFieldGroups",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "Entity",
                schema: "dbo",
                table: "Resources",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ModuleName",
                schema: "dbo",
                table: "Modules",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<Guid>(
                name: "HeadquarterId",
                schema: "dbo",
                table: "HeadquartersInformation",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomFieldId",
                schema: "dbo",
                table: "HeadquartersInformation",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<byte>(
                name: "Order",
                schema: "dbo",
                table: "Headquarters",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValueSql: "((0))");

            migrationBuilder.AlterColumn<string>(
                name: "HeadquarterCity",
                schema: "dbo",
                table: "Headquarters",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.RenameColumn(
                name: "HeadquarterMainAddress",
                newName: "HeadquarterAddress",
                schema: "dbo",
                table: "Headquarters");

            migrationBuilder.AlterColumn<string>(
                name: "CustomFieldValues",
                schema: "dbo",
                table: "CustomFields",
                type: "text",
                nullable: true,
                defaultValueSql: "('')",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomFieldGroupId",
                schema: "dbo",
                table: "CustomFields",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                schema: "dbo",
                table: "CustomFieldGroups",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                schema: "dbo",
                table: "CustomFieldGroups",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "dbo",
                table: "CustomFieldGroups",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid));

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
                        name: "FK_Seasons_Seasons_ParentSeasonId",
                        column: x => x.ParentSeasonId,
                        principalSchema: "dbo",
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeasonStates",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),                    
                    HeadquarterId = table.Column<Guid>(nullable: true),
                    ModuleId = table.Column<Guid>(nullable: true),
                    SeasonId = table.Column<Guid>(nullable: true),
                    State = table.Column<string>(nullable: false),
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
                        name: "FK_SeasonStates_Headquarters_HeadquarterId",
                        column: x => x.HeadquarterId,
                        principalSchema: "dbo",
                        principalTable: "Headquarters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeasonStates_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalSchema: "dbo",
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeasonStates_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalSchema: "dbo",
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: new Guid("cddf7d8b-4fee-e611-8954-34e6d700b0a5"),
                column: "Acronym",
                value: "CAPALTO");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomFieldGroups",
                schema: "dbo",
                table: "CustomFields",
                column: "CustomFieldGroupId",
                principalSchema: "dbo",
                principalTable: "CustomFieldGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HeadquartersInformation_CustomFields",
                schema: "dbo",
                table: "HeadquartersInformation",
                column: "CustomFieldId",
                principalSchema: "dbo",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HeadquartersInformation_Headquarters",
                schema: "dbo",
                table: "HeadquartersInformation",
                column: "HeadquarterId",
                principalSchema: "dbo",
                principalTable: "Headquarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
