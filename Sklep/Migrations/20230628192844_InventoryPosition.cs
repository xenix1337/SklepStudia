using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Sklep.Migrations
{
    /// <inheritdoc />
    public partial class InventoryPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "position_id",
                table: "product",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "inventory_position",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rack = table.Column<int>(type: "integer", nullable: false),
                    shelf = table.Column<int>(type: "integer", nullable: false),
                    amount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_inventory_position", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_product_position_id",
                table: "product",
                column: "position_id");

            migrationBuilder.AddForeignKey(
                name: "fk_product_inventory_positions_position_id",
                table: "product",
                column: "position_id",
                principalTable: "inventory_position",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_product_inventory_positions_position_id",
                table: "product");

            migrationBuilder.DropTable(
                name: "inventory_position");

            migrationBuilder.DropIndex(
                name: "ix_product_position_id",
                table: "product");

            migrationBuilder.DropColumn(
                name: "position_id",
                table: "product");
        }
    }
}
