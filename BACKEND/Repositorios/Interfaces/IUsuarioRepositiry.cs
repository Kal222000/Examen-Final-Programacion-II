using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BACKEND.Modelos;

namespace BACKEND.Repositorios.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> ObtenerUsuarios();

        Task CrearUsuario(Usuario usuario);

        Task<int> ValidarUsuario(int carnet);
    }
}