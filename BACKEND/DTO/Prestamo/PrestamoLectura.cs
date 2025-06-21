using System;

namespace BACKEND.DTO.Prestamo
{
    public class PrestamoLecturaDTO
    {
        public int ReservaDetalleID { get; set; }

        public DateTime FechaRecogida { get; set; }

        public DateTime FechaVencimientoPrestamo { get; set; }

        public DateTime FechaDevolucionReal { get; set; }
    }
}