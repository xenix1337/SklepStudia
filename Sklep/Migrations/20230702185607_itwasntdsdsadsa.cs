using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sklep.Migrations
{
    /// <inheritdoc />
    public partial class itwasntdsdsadsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "unit_price",
                table: "receipt_position",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer"
            );

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "receipt_position",
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
                name: "unit_price",
                table: "receipt_position",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric"
            );

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "receipt_position",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric"
            );
        }
    }
}
