using Microsoft.EntityFrameworkCore;
using ProyectoComex.Models;

namespace ProyectoComex.Data {
	public class ComexContext: DbContext {
		public DbSet<Cliente> Clientes { get; set; }
		public ComexContext(DbContextOptions<ComexContext> options): base(options) {

		}
	}
}
