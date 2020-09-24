using Microsoft.EntityFrameworkCore.Migrations;

namespace Cookbook.DAL.Migrations
{
    public partial class AddingEnums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Recipe");

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Unit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Recipe",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CookingDifficultiesId",
                table: "Recipe",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CookingDifficulty",
                table: "Recipe",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DifficultyCategory",
                table: "Recipe",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "CookingDifficultiesId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "CookingDifficulty",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "DifficultyCategory",
                table: "Recipe");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
