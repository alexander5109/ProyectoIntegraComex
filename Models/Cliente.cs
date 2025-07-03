using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProyectoComex.Models {
	public class Cliente {
		[Key]
		public int Id { get; set; }

		[Remote(action: "ClienteCUITExists", controller: "Clientes")]
		[Required(ErrorMessage = "El CUIT es obligatorio.")]
		[StringLength(11, MinimumLength = 11, ErrorMessage = "El CUIT debe tener 11 digitos")]
		public string CUIT { get; set; }

		[Required(ErrorMessage = "La razón social es obligatoria.")]
		public string RazonSocial { get; set; }

		[Required(ErrorMessage = "El teléfono es mandatorio")]
		[StringLength(10, MinimumLength = 10, ErrorMessage = "El teléfono debe tener 10 digitos. No es necesario +54 ni que empiece 0. Ejemplo: 1338830130")]
		//[RegularExpression(@"^\d{10}$", ErrorMessage = "El teléfono debe contener solo números.")]
		[RegularExpression(@"^[1-9]\d{9}$", ErrorMessage = "El teléfono debe contener 10 números (no hace falta +54) y no puede empezar con 0. Ejemplo: 1338830130")]

		public string Telefono { get; set; }

		[StringLength(200, ErrorMessage = "La dirección solo puede contener hasta 200 caracteres.")]
		public string Direccion { get; set; }

		public bool Activo { get; set; }
	}
}