using Microsoft.EntityFrameworkCore;
using ProyectoComex.Models;

namespace ProyectoComex.Data {
	public class BaseDeDatos {
		private readonly ComexContext _context;
		public BaseDeDatos(ComexContext context) {
			_context = context;
		}



		public async Task<IEnumerable<Cliente>> ReadAllClientes() {
			return await _context.Clientes.ToListAsync();
		}

		public async Task<bool> ClienteCUITExists(string cuit) {
			return await _context.Clientes.AnyAsync(c => c.CUIT == cuit);
		}
		

		public async Task<Cliente?> ReadOneCliente(int id) {
			return await _context.Clientes.FindAsync(id);
		}

		public async Task CreateCliente(Cliente cliente) {
			await _context.Clientes.AddAsync(cliente);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateCliente(Cliente cliente) {
			_context.Clientes.Update(cliente);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteCliente(int id) {
			var cliente = await _context.Clientes.FindAsync(id);
			if (cliente != null) {
				_context.Clientes.Remove(cliente);
				await _context.SaveChangesAsync();
			}
		}

	}
}
