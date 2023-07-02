using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sklep.Migrations
{
    /// <inheritdoc />
    public partial class varfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "receipt_item",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer"
            );

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "inventory_position",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer"
            );

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "inventory_change",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "amount",
                table: "receipt_item",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric"
            );

            migrationBuilder.AlterColumn<int>(
                name: "amount",
                table: "inventory_position",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric"
            );

            migrationBuilder.AlterColumn<int>(
                name: "amount",
                table: "inventory_change",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric"
            );
        }
    }
}
