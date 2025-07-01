using Microsoft.EntityFrameworkCore;
using ProyectoComex.Models;

namespace ProyectoComex.Data {
	public class ComexContext: DbContext {
		public required DbSet<Cliente> Clientes { get; set; }
		public ComexContext(DbContextOptions<ComexContext> options): base(options) {

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Cliente>().HasData(
				new Cliente {
					Id = 1,
					CUIT = "20345678901",
					RazonSocial = "Ferretería San José",
					Telefono = "1123456789",
					Direccion = "Av. Mitre 1234",
					Activo = true
				},
				new Cliente {
					Id = 2,
					CUIT = "27345678902",
					RazonSocial = "Distribuidora El Sol",
					Telefono = "1134567890",
					Direccion = "Calle Falsa 123",
					Activo = true
				},
				new Cliente {
					Id = 3,
					CUIT = "30765432109",
					RazonSocial = "Panadería La Espiga",
					Telefono = "1145678901",
					Direccion = "San Martín 456",
					Activo = false
				}
			// ...otros
			);
		}



	}
}
