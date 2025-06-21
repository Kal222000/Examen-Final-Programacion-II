using System;

namespace BACKEND.DTO.ReservaDetalle
{
    public class ReservaDetalleLecturaDTO
    {
        public DateTime FechaExpiracion { get; set; }

        public string EstadoDetalle { get; set; }

        public int Copia { get; set; }

        public string LibroID { get; set; }
    }
}