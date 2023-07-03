using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Sklep.Migrations
{
    /// <inheritdoc />
    public partial class InventoryPositionFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inventory_change",
                columns: table =>
                    new
                    {
                        id = table
                            .Column<int>(type: "integer", nullable: false)
                            .Annotation(
                                "Npgsql:ValueGenerationStrategy",
                                NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                            ),
                        position_id = table.Column<int>(type: "integer", nullable: true),
                        type = table.Column<int>(type: "integer", nullable: false),
                        amount = table.Column<int>(type: "integer", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("pk_inventory_change", x => x.id);
                    table.ForeignKey(
                        name: "fk_inventory_change_inventory_position_position_id",
                        column: x => x.position_id,
                        principalTable: "inventory_position",
                        principalColumn: "id"
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "ix_inventory_change_position_id",
                table: "inventory_change",
                column: "position_id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "inventory_change");
        }
    }
}
