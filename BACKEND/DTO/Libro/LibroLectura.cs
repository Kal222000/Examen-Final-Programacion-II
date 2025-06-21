using System;
using System.Collections.Generic;

namespace BACKEND.DTO.Libro
{
    public class LibroLecturaDTO
    {
        public string _id { get; set; }

        public string titulo { get; set; }

        public string autor { get; set; }

        public string genero { get; set; }

        public DateTime fechaPublicacion { get; set; }

        public List<CopiaLibroDTO> copies { get; set; }
    }
}