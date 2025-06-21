using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BACKEND.Modelos
{
    public class Prestamos
    {
        [Key]
        public int ReservaDetalleID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaRecogida { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaVencimientoPrestamo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaDevolucionReal { get; set; }

        [ForeignKey("ReservaID")]
        public ReservaDetalle ReservaDetalle { get; set; }
    }
}