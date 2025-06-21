using BACKEND.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BACKEND.Datos.Mongo.Interfaces
{
    public interface ILibroRepository
    {
        Task<List<Libro>> GetAllAsync();

        Task<Libro> GetByIdAsync(string id);

        Task CreateAsync(Libro nuevo_Libro);

        Task UpdateAsync(string id, Libro actualizar_Libro);

        Task RemoveAsync(string id);
    }
}