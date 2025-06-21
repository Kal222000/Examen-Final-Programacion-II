using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO.Prestamo
{
    public class PrestamoActualizarDTO
    {
        public DateTime FechaRecogida { get; set; }

        public DateTime FechaVencimientoPrestamo { get; set; }

        public DateTime FechaDevolucionReal { get; set; }
    }
}