using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO.ReservaDetalle
{
    public class ReservaDetalleCrearDTO
    {
        [Required(ErrorMessage = "Solicitud del ID es obligatorio.")]
        public int SolicitudID { get; set; }

        [Required(ErrorMessage = "Libro ID es obligatorio.")]
        [StringLength(24, ErrorMessage = "El libro ID no puede exceder los 24 caracteres.")]
        public string LibroID { get; set; }

        [Required(ErrorMessage = "Copia es obligatorio.")]
        public int Copia { get; set; }

        [Required(ErrorMessage = "Fecha de Expiracion es obligatorio.")]
        [DataType(DataType.Date)]
        public DateTime FechaExpiracion { get; set; }

        [Required(ErrorMessage = "El Estado del Detalle es obligatorio.")]
        [StringLength(20, ErrorMessage = "El Estado del Detalle no puede exceder los 20 caracteres.")]
        public string EstadoDetalle { get; set; } = "pendiente";
    }
}