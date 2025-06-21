using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO.Prestamo
{
    public class PrestamoCrearDTO
    {
        [Required(ErrorMessage = "Detalle ID de Reserva es obligatorio")]
        public int ReservaDetalleID { get; set; }

        [Required(ErrorMessage = "Fecha de Recogida es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaRecogida { get; set; }

        [Required(ErrorMessage = "Fecha de Vencimiento es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaVencimientoPrestamo { get; set; }

        [Required(ErrorMessage = "Fecha de Devolucion es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaDevolucionReal { get; set; }
    }
}