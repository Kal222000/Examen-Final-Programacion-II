using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO.SolicitudReserva
{
    public class SolicitudReservaCrearDTO
    {
        [Required(ErrorMessage = "El ID del Usuario es obligatorio.")]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "La Fecha de Solicitud es obligatorio.")]
        [DataType(DataType.Date)]
        public DateTime FechaSolicitud { get; set; }

        [Required(ErrorMessage = "El Estado de la Solicitud es obligatorio.")]
        [StringLength(20, ErrorMessage = "El Estado de la Solicitud no puede exceder los 20 caracteres.")]
        public string EstadoSolicitud { get; set; } = "pendiente";
    }
}