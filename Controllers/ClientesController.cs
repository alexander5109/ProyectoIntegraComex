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




		//Create
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



		//Read
		public async Task<IActionResult> Index() {
			return View(await _service.ReadClientes());
		}




		//Update
		[HttpGet]
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
		public async Task<IActionResult> Update(Cliente remotecliente) {
			if (ModelState.IsValid) {
				await _service.UpdateCliente(remotecliente);
				return RedirectToAction("Index");   //simply return the get version of the page
			}
			return View(remotecliente);	//return the same page (or do nothing)
		}



		//Delete


	}
}
