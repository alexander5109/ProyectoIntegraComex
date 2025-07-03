﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoComex.Migrations
{
    /// <inheritdoc />
    public partial class CuitAsUniqueField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CUIT",
                table: "Clientes",
                column: "CUIT",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Clientes_CUIT",
                table: "Clientes");
        }
    }
}
