using Microsoft.EntityFrameworkCore.Migrations;

namespace Cookbook.DAL.Migrations
{
    public partial class AddedNuronlVuesToRecipeEnti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NutritionalValuesEntityId",
                table: "Recipe",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_NutritionalValuesEntityId",
                table: "Recipe",
                column: "NutritionalValuesEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_NutritionalValues_NutritionalValuesEntityId",
                table: "Recipe",
                column: "NutritionalValuesEntityId",
                principalTable: "NutritionalValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_NutritionalValues_NutritionalValuesEntityId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_NutritionalValuesEntityId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "NutritionalValuesEntityId",
                table: "Recipe");
        }
    }
}
