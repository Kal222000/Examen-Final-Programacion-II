using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO.Login
{
    public class LoginCrearDTO
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string contrasena { get; set; }
    }
}