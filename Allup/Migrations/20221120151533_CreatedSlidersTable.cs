using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class CreatedSlidersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<string>(nullable: true),
                    DeletedBy = table.Column<DateTime>(nullable: true),
                    MainTitle = table.Column<string>(maxLength: 1000, nullable: true),
                    SubTitle = table.Column<string>(maxLength: 2000, nullable: true),
                    Desc = table.Column<string>(maxLength: 2500, nullable: true),
                    Image = table.Column<string>(maxLength: 3000, nullable: true),
                    PageLink = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
