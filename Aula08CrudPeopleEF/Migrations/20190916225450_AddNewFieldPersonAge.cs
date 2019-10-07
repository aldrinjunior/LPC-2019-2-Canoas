using Microsoft.EntityFrameworkCore.Migrations;

namespace Aula08CrudPeopleEF.Migrations
{
    public partial class AddNewFieldPersonAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "People",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "People");
        }
    }
}
