using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sklep.Migrations
{
    /// <inheritdoc />
    public partial class addedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "date",
                table: "inventory_change",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1)
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "date", table: "inventory_change");
        }
    }
}
