using Microsoft.AspNetCore.Mvc;
using ProyectoComex.Data;
using ProyectoComex.Models;

namespace ProyectoComex.Controllers {
	public class ClientesController : Controller {
		private readonly ComexContext _context;
		public ClientesController(ComexContext context) {
			_context = context;
		}

		public IActionResult Index() {

			List<Cliente> clientes = _context.Clientes.ToList();
			return View(clientes);
		}
		public IActionResult Create() {
			return View();
		}
		[HttpPost]
		public IActionResult Create(Cliente cliente) {
			if (ModelState.IsValid) {
				_context.Clientes.Add(cliente);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
