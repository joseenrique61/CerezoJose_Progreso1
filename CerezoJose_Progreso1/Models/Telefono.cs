using System.ComponentModel.DataAnnotations;

namespace CerezoJose_Progreso1.Models
{
	public class Telefono
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Modelo { get; set; }

		[Required]
		[Range(1600, 2024)]
		public int Anio { get; set; }

		[Required]
		[DataType(DataType.Currency)]
		public double Precio { get; set; }
	}
}
