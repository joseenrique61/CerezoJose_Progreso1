using System.ComponentModel.DataAnnotations;

namespace CerezoJose_Progreso1.Models
{
	public class JoseCerezo
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Nombre { get; set; }

		[Required]
		public int CantidadHermanos { get; set; }

		[Required]
		public double SaldoBancario { get; set; }

		[Required]
		public bool EsHombre { get; set; }

		[Required]
		public DateTime FechaNacimiento { get; set; }
	}
}
