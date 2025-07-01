using Microsoft.EntityFrameworkCore;
using ProyectoComex.Models;

namespace ProyectoComex.Data.Service {
	public class ClienteService : IComexService {
		private readonly ComexContext _context;
		public ClienteService(ComexContext context) {
			_context = context;
		}



		public async Task<IEnumerable<Cliente>> ReadClientes() {
			return await _context.Clientes.ToListAsync();
		}



		public async Task<Cliente?> GetCliente(int id) {
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
	}
}
