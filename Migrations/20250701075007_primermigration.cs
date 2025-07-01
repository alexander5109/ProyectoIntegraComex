using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoComex.Migrations
{
    /// <inheritdoc />
    public partial class primermigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUIT = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Activo", "CUIT", "Direccion", "RazonSocial", "Telefono" },
                values: new object[,]
                {
                    { 1, true, "20345678901", "Av. Mitre 1234", "Ferretería San José", "1123456789" },
                    { 2, true, "27345678902", "Calle Falsa 123", "Distribuidora El Sol", "1134567890" },
                    { 3, false, "30765432109", "San Martín 456", "Panadería La Espiga", "1145678901" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
