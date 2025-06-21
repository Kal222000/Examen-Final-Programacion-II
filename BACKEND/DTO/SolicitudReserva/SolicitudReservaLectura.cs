using System;

namespace BACKEND.DTO.SolicitudReserva
{
    public class SolicitudReservaLecturaDTO
    {
        public DateTime FechaSolicitud { get; set; }

        public string EstadoSolicitud { get; set; }

        public int UsuarioID { get; set; }
    }
}