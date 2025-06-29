using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoComex.Data;
using ProyectoComex.Data.Service;
using ProyectoComex.Models;
using System.Data.Entity;


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




		//[HttpGet]
		public async Task<IActionResult> Update(int? id) {
			if (id == null)
				return NotFound();
			var cliente = await _service.GetCliente(id.Value);

			if (cliente == null)
				return NotFound();

			return View(cliente);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Update(int? id) {
			if (ModelState.IsValid) {
				await _service.UpdateCliente(cliente);
				return RedirectToAction("Index");
			}
			return View(cliente);
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
