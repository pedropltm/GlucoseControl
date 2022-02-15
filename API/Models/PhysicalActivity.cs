using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GlucoseControl.Models
{
    public class PhysicalActivity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; } = null!; //mandatory string property
        //public PhysicalActivityType Type { get; set; }
    }
}