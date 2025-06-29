using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoComex.Migrations
{
    /// <inheritdoc />
    public partial class firstClientes : Migration
    {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.InsertData(
				table: "Clientes",
				columns: new[] { "CUIT", "RazonSocial", "Telefono", "Direccion", "Activo" },
				values: new object[,]
				{
			{ "20345678901", "Ferretería San José", "1123456789", "Av. Mitre 1234", true },
			{ "27345678902", "Distribuidora El Sol", "1134567890", "Calle Falsa 123", true },
			{ "30765432109", "Panadería La Espiga", "1145678901", "San Martín 456", false },
			{ "20111222333", "Tienda Los Amigos", "1155672301", "Av. Rivadavia 2222", true },
			{ "30123456789", "Servicios ABC S.A.", "1156789012", "Italia 555", false }
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
