using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEDN.DTO.ReservaDetalle
{
    public class ReservaDetalleActualizarDTO
    {
        [StringLength(20, ErrorMessage = "El Estado del Detalle no puede exceder los 20 caracteres.")]
        public string EstadoDetalle { get; set; }
    }
}