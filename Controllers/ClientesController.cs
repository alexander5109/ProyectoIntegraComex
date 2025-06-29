using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoComex.Data;
using ProyectoComex.Models;

namespace ProyectoComex.Controllers {
	public class ClientesController : Controller {
		private readonly ComexContext _context;
		public ClientesController(ComexContext context) {
			_context = context;
		}

		public async Task<IActionResult> Index() {

			List<Cliente> clientes = await _context.Clientes.ToListAsync();
			return View(clientes);
		}


		[HttpGet]
		public IActionResult Create() {
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Cliente cliente) {
			if (ModelState.IsValid) {
				await _context.Clientes.AddAsync(cliente);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return View(cliente);
		}
	}
}
