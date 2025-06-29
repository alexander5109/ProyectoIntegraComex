using Microsoft.EntityFrameworkCore;
using ProyectoComex.Models;

namespace ProyectoComex.Data.Service {
	public class ClienteService : IComexService {
		private readonly ComexContext _context;
		public ClienteService(ComexContext context) {
			_context = context;
		}


		public async Task CreateCliente(Cliente cliente) {
			await _context.Clientes.AddAsync(cliente);
			await _context.SaveChangesAsync();
		}



		public async Task<IEnumerable<Cliente>> ReadClientes() {
			return await _context.Clientes.ToListAsync();
		}



	}
}
