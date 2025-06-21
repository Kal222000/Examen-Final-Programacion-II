using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO.SolicitudReserva
{
    public class SolicitudReservaActualizarDTO
    {
        [StringLength(20, ErrorMessage = "El Estado de la Solicitud no puede exceder los 20 caracteres.")]
        public string EstadoSolicitud { get; set; }
    }
}