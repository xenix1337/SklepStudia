using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Sklep.Migrations
{
    /// <inheritdoc />
    public partial class receiptsContex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "receipt",
                columns: table =>
                    new
                    {
                        id = table
                            .Column<int>(type: "integer", nullable: false)
                            .Annotation(
                                "Npgsql:ValueGenerationStrategy",
                                NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                            ),
                        date = table.Column<DateTime>(
                            type: "timestamp with time zone",
                            nullable: false
                        )
                    },
                constraints: table =>
                {
                    table.PrimaryKey("pk_receipt", x => x.id);
                }
            );

            migrationBuilder.CreateTable(
                name: "receipt_item",
                columns: table =>
                    new
                    {
                        id = table
                            .Column<int>(type: "integer", nullable: false)
                            .Annotation(
                                "Npgsql:ValueGenerationStrategy",
                                NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                            ),
                        receipt_id = table.Column<int>(type: "integer", nullable: false),
                        product_id = table.Column<int>(type: "integer", nullable: false),
                        amount = table.Column<int>(type: "integer", nullable: false),
                        unit_price = table.Column<int>(type: "integer", nullable: false),
                        price = table.Column<int>(type: "integer", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("pk_receipt_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_receipt_item_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "fk_receipt_item_receipts_receipt_id",
                        column: x => x.receipt_id,
                        principalTable: "receipt",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "ix_receipt_item_product_id",
                table: "receipt_item",
                column: "product_id"
            );

            migrationBuilder.CreateIndex(
                name: "ix_receipt_item_receipt_id",
                table: "receipt_item",
                column: "receipt_id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "receipt_item");

            migrationBuilder.DropTable(name: "receipt");
        }
    }
}
