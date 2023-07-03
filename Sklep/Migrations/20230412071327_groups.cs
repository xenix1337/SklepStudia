using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Sklep.Migrations
{
    /// <inheritdoc />
    public partial class groups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product_group",
                columns: table =>
                    new
                    {
                        id = table
                            .Column<int>(type: "integer", nullable: false)
                            .Annotation(
                                "Npgsql:ValueGenerationStrategy",
                                NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                            ),
                        group_barcode = table.Column<string>(type: "text", nullable: true),
                        product_id = table.Column<int>(type: "integer", nullable: true),
                        amount = table.Column<int>(type: "integer", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product_group", x => x.id);
                    table.ForeignKey(
                        name: "fk_product_group_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "id"
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "ix_product_group_product_id",
                table: "product_group",
                column: "product_id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "product_group");
        }
    }
}
