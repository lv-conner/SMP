using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMP.Web.Migrations
{
    public partial class addRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register");
        }
    }
}
