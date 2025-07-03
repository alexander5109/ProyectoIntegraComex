using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoComex.Data;
using ProyectoComex.Models;


namespace ProyectoComex.Controllers {
	public class ClientesController : Controller {
		private readonly BaseDeDatos _service;
		public ClientesController(BaseDeDatos service) {
			_service = service;
		}
		
		[HttpGet]
		public async Task<IActionResult> GetRazonSocial(string cuit) {
			if (!cuit.All(char.IsDigit)) {
				return BadRequest("El CUIT debe contener solo dígitos.");
			}
			using var httpClient = new HttpClient();
			var url = $"https://sistemaintegracomex.com.ar/Account/GetNombreByCuit?cuit={cuit}";

			try {
				var razonSocial = await httpClient.GetStringAsync(url);
				return Ok(razonSocial); // esto devuelve texto plano al cliente
			} catch {
				return NotFound("CUIT no válido");
			}
		}


		[AcceptVerbs("GET", "POST")]
		public async Task<IActionResult> ValidateCUIT(string cuit) {
			if (await _service.ClienteCUITExists(cuit)) {
				return Json($"Ya existe un cliente con el CUIT {cuit}.");
			}
			return Json(true);
		}





		//CreateCliente
		[HttpGet]
		public IActionResult Create() {
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Cliente remotecliente) {
			if (await _service.ClienteCUITExists(remotecliente.CUIT)) {
				ModelState.AddModelError("CUIT", "Ya existe un cliente con ese CUIT.");
			}
			if (ModelState.IsValid) {
				await _service.CreateCliente(remotecliente);
				return RedirectToAction("Index");
			}
			return View(remotecliente);
		}


		//Read
		public async Task<IActionResult> Index() {
			return View(await _service.ReadAllClientes());
		}


		//UpdateCliente
		[HttpGet]
		public async Task<IActionResult> Update(int? id) {
			if (id == null)
				return NotFound();
			var cliente = await _service.ReadOneCliente(id.Value);

			if (cliente == null)
				return NotFound();

			return View(cliente);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Update(Cliente remotecliente) {
			if (await _service.ClienteCUITExists(remotecliente.CUIT)) {
				ModelState.AddModelError("CUIT", "Ya existe un cliente con ese CUIT.");
			}
			if (ModelState.IsValid) {
				await _service.UpdateCliente(remotecliente);
				return RedirectToAction("Index");   //simply return the get version of the page
			}
			return View(remotecliente);	//return the same page (or do nothing)
		}

		//DeleteCliente
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(int id) {
			await _service.DeleteCliente(id);
			return RedirectToAction("Index");
		}


	}
}
