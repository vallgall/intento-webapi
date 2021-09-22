using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intento1.Models
{
    public class Beer
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("alcohol")]
        public decimal Alcohol { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
