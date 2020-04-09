using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoConsole.Migrations
{
    public partial class DirectorsDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Steven Spielberg" },
                    { 2, "Martin Scorsese" },
                    { 3, "Quentin Jerome Tarantino" },
                    { 4, "Christopher Jonathan James Nolan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
