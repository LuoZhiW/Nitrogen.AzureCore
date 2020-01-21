using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nitrogen.Data.Mysql.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PermissionsCategories",
                columns: table => new
                {
                    PermissionsCategoryId = table.Column<Guid>(nullable: false),
                    PermissionsCategoryName = table.Column<string>(nullable: true),
                    PermissionCategoryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionsCategories", x => x.PermissionsCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<Guid>(nullable: false),
                    PermissionCode = table.Column<string>(nullable: true),
                    PermissionName = table.Column<string>(nullable: true),
                    PermissionsCategoryId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: true),
                    LastUpdateUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionsCategories_PermissionsCategoryId",
                        column: x => x.PermissionsCategoryId,
                        principalTable: "PermissionsCategories",
                        principalColumn: "PermissionsCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionsCategoryId",
                table: "Permissions",
                column: "PermissionsCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PermissionsCategories");
        }
    }
}
