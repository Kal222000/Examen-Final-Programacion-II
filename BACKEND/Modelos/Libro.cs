using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BACKEND.Modelos
{
    public class Libro
    {
        [BsonId] 
        [BsonRepresentation(BsonType.ObjectId)] 
        public string _id { get; set; } 

        public string titulo { get; set; }

        public string autor { get; set; }

        public string genero { get; set; }

        public DateTime fechaPublicacion { get; set; }

        public bool eliminado { get; set; } = false;

        public List<CopiaLibro> copies { get; set; } = new List<CopiaLibro>();
    }

    public class CopiaLibro
    {
        public int copyId { get; set; }

        public string editorial { get; set; }

        public string estado { get; set; } = "disponible";

        public bool eliminado { get; set; } = false;
    }
}