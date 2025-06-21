using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO.Libro
{
    public class LibroCrearDTO
    {
        [Required(ErrorMessage = "El titulo es obligatorio.")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio.")]
        public string autor { get; set; }

        public string genero { get; set; }

        [Required(ErrorMessage = "La fecha de publicacion es obligatoria.")]
        public DateTime fechaPublicacion { get; set; }

        public List<CopiaLibroDTO> copies { get; set; } = new List<CopiaLibroDTO>();
    }

    public class CopiaLibroDTO
    {
        public int copyId { get; set; }

        [Required(ErrorMessage = "La editorial es obligatoria.")]
        public string editorial { get; set; }

        public string estado { get; set; } = "disponible";
    }
}