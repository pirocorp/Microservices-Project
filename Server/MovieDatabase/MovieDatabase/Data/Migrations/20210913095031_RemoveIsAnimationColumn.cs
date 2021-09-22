using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieDatabase.Migrations
{
    public partial class RemoveIsAnimationColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnimation",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "IsAnimation",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAnimation",
                table: "Series",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAnimation",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
