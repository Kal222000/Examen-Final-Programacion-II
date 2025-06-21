using BACKEND.Datos.Mongo.Interfaces;
using BACKEND.Modelos;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BACKEND.Datos.Mongo.Implementations
{
    public class LibroRepository : ILibroRepository
    {
        private readonly IMongoCollection<Libro> _librosCollection;

        public LibroRepository()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();

            var mongoDbSettings = new MongoDbSettings();
            configuration.GetSection("MongoDbSettings").Bind(mongoDbSettings);

            if(string.IsNullOrEmpty(mongoDbSettings.ConnectionString) ||
               string.IsNullOrEmpty(mongoDbSettings.DatabaseName) ||
               string.IsNullOrEmpty(mongoDbSettings.CollectionName))
            {
                throw new InvalidOperationException("Error al conectarse a Mongo, revisar appsettings.json");
            }

            var mongoCliente = new MongoClient(mongoDbSettings.ConnectionString);
            var mongoBase = mongoCliente.GetDatabase(mongoDbSettings.DatabaseName);
            _librosCollection = mongoBase.GetCollection<Libro>(mongoDbSettings.CollectionName);
        }

        public async Task<List<Libro>> GetAllAsync() => await _librosCollection.Find(_ => true).ToListAsync();

        public async Task<Libro> GetByIdAsync(string id) => await _librosCollection.Find(x => x._id == id).FirstOrDefaultAsync();

        public async Task CreateAsync (Libro nuevo_Libro) => await _librosCollection.InsertOneAsync(nuevo_Libro);

        public async Task UpdateAsync(string id, Libro actualizar_Libro) => await _librosCollection.ReplaceOneAsync(x => x._id == id, actualizar_Libro);

        public async Task RemoveAsync(string id) => await _librosCollection.DeleteOneAsync(x => x._id == id);
    }
}
