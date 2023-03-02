using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleRoseNoir.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFKProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variations_Products_ProductId",
                table: "Variations");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Variations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Variations_Products_ProductId",
                table: "Variations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variations_Products_ProductId",
                table: "Variations");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Variations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Variations_Products_ProductId",
                table: "Variations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }
    }
}
