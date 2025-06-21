using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BACKEND.Modelos
{
	public class Usuarios
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UsuarioID { get; set; }

		[Required]
		[StringLength(100)]
		public string Nombre { get; set; }

		[Required]
		[StringLength(100)]
		public string ApellidoPaterno { get; set; }

		[StringLength(100)]
		public string ApellidoMaterno { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime FechaNacimiento { get; set; }

		[Required]
		public int Carnet { get; set; }

		public int Rol { get; set; }

        public ICollection<SolicitudReserva> Solicitudes { get; set; }
    }
}