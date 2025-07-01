using System.ComponentModel.DataAnnotations;

namespace ProyectoComex.Models {
	public class Cliente {
		public int Id { get; set; }

		[Required]
		[StringLength(11, MinimumLength = 11)]
		public string CUIT { get; set; }

		[Required]
		public string RazonSocial { get; set; }

		[Phone]
		public string Telefono { get; set; }

		[StringLength(200)]
		public string Direccion { get; set; }

		public bool Activo { get; set; }
	}
}