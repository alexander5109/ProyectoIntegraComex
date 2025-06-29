using ProyectoComex.Models;

namespace ProyectoComex.Data.Service {
	public interface IComexService {
		Task<IEnumerable<Cliente>> ReadClientes();
		Task CreateCliente(Cliente cliente);


		Task UpdateCliente(Cliente cliente);

		Task<Cliente?> GetCliente(int id);
	}
}
