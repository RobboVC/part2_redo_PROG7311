using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prog7311_part2_redo.Data.Migrations
{
    public partial class updatemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Farmer",
                newName: "FarmerId");

            migrationBuilder.AddColumn<int>(
                name: "FarmerId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_FarmerId",
                table: "Product",
                column: "FarmerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Farmer_FarmerId",
                table: "Product",
                column: "FarmerId",
                principalTable: "Farmer",
                principalColumn: "FarmerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Farmer_FarmerId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_FarmerId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "FarmerId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "FarmerId",
                table: "Farmer",
                newName: "Id");
        }
    }
}
