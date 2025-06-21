using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO.Usuario
{
    public class UsuarioCrearDTO
    {
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido paterno es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido paterno no puede exceder los 100 caracteres.")]
        public string ApellidoPaterno { get; set; }

        [StringLength(100, ErrorMessage = "El apellido materno no puede exceder los 100 caracteres.")]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "La Fecha de Nacimiento es obligatorio.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int Carnet { get; set; }

        public int Rol { get; set; } = 1;
    }
}