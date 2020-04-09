using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoConsole.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Age", "FullName" },
                values: new object[,]
                {
                    { 1, (byte)55, "Jack Nicholson" },
                    { 2, (byte)68, "Marlon Brando" },
                    { 3, (byte)54, "Robert De Niro" },
                    { 4, (byte)64, "Al Pacino" },
                    { 5, (byte)55, "Tom Hanks" },
                    { 6, (byte)66, "Anthony Hopkins" },
                    { 7, (byte)60, "Denzel Washington" },
                    { 8, (byte)61, "Morgan Freeman" },
                    { 9, (byte)70, "Clint Eastwood" },
                    { 10, (byte)30, "Leonardo DiCaprio" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DirectorId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Jaws" },
                    { 2, 2, "The Wolf of Wall Street" },
                    { 3, 3, "Pulp Fiction" },
                    { 4, 4, "Interstellar" }
                });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 6, 2 },
                    { 8, 4 },
                    { 7, 4 },
                    { 4, 4 },
                    { 3, 4 },
                    { 2, 4 },
                    { 10, 3 },
                    { 9, 3 },
                    { 8, 3 },
                    { 4, 3 },
                    { 2, 3 },
                    { 10, 4 },
                    { 5, 2 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 2 },
                    { 1, 1 },
                    { 9, 4 }
                });

            migrationBuilder.InsertData(
                table: "Awards",
                columns: new[] { "Title", "Year", "ActorId" },
                values: new object[,]
                {
                    { "GoldenGlobe", (short)2018, 3 },
                    { "BAFTA", (short)2018, 2 },
                    { "Oscar", (short)2019, 2 },
                    { "BAFTA", (short)2019, 1 },
                    { "GoldenGlobe", (short)2019, 1 },
                    { "Oscar", (short)2018, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumns: new[] { "Title", "Year" },
                keyValues: new object[] { "Oscar", (short)2018 });

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumns: new[] { "Title", "Year" },
                keyValues: new object[] { "Oscar", (short)2019 });

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumns: new[] { "Title", "Year" },
                keyValues: new object[] { "GoldenGlobe", (short)2018 });

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumns: new[] { "Title", "Year" },
                keyValues: new object[] { "GoldenGlobe", (short)2019 });

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumns: new[] { "Title", "Year" },
                keyValues: new object[] { "BAFTA", (short)2018 });

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumns: new[] { "Title", "Year" },
                keyValues: new object[] { "BAFTA", (short)2019 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
