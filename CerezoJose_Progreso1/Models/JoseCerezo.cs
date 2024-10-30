using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CerezoJose_Progreso1.Models
{
	public class JoseCerezo
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Nombre { get; set; }

		[Required]
		[Range(0, 100)]
		[DisplayName("Cantidad de hermanos")]
		public int CantidadHermanos { get; set; }

		[Required]
		[DisplayName("Saldo bancario")]
		[DataType(DataType.Currency)]
		public double SaldoBancario { get; set; }

		[Required]
		[DisplayName("Es hombre")]
		public bool EsHombre { get; set; }

		[Required]
		[DisplayName("Fecha de nacimiento")]
		[Description("Fecha en la que nació el usuario.")]
		[DataType(DataType.Date)]
		public DateTime FechaNacimiento { get; set; }

		[Required]
		[ForeignKey(nameof(Telefono))]
		[DisplayName(nameof(Telefono))]
		public int TelefonoId { get; set; }

		public Telefono? Telefono { get; set; }
	}
}
