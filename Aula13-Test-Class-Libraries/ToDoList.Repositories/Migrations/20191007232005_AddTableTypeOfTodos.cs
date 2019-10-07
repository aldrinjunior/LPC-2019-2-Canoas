using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ToDoList.Repositories.Migrations
{
    public partial class AddTableTypeOfTodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeToDoid",
                table: "Todos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeTodos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTodos", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_TypeToDoid",
                table: "Todos",
                column: "TypeToDoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_TypeTodos_TypeToDoid",
                table: "Todos",
                column: "TypeToDoid",
                principalTable: "TypeTodos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_TypeTodos_TypeToDoid",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "TypeTodos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_TypeToDoid",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "TypeToDoid",
                table: "Todos");
        }
    }
}
