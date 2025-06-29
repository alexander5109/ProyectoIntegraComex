using Microsoft.AspNetCore.Mvc;
using ProyectoComex.Data;

namespace ProyectoComex.Controllers {
	public class ClientsController : Controller {
		private readonly ComexContext _context;
		public ClientsController(ComexContext context) {
			_context = context;
		}

		public IActionResult Index() {
			return View();
		}
	}
}
