using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoComex.Data;
using ProyectoComex.Models;
using ProyectoComex.Data.Service;


namespace ProyectoComex.Controllers {
	public class ClientesController : Controller {
		private readonly IComexService _service;
		public ClientesController(IComexService service) {
			_service = service;
		}

		public async Task<IActionResult> Index() {
			return View(await _service.ReadClientes());
		}


		[HttpGet]
		public IActionResult Create() {
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Cliente cliente) {
			if (ModelState.IsValid) {
				await _service.CreateCliente(cliente);
				return RedirectToAction("Index");
			}
			return View(cliente);
		}
	}
}
