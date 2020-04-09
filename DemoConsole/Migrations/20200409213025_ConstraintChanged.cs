using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoConsole.Migrations
{
    public partial class ConstraintChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_Actors_ActorId1",
                table: "Awards");

            migrationBuilder.DropIndex(
                name: "IX_Awards_ActorId1",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "ActorId1",
                table: "Awards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActorId1",
                table: "Awards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Awards_ActorId1",
                table: "Awards",
                column: "ActorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_Actors_ActorId1",
                table: "Awards",
                column: "ActorId1",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
