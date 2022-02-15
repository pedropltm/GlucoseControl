using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GlucoseControl.Models
{
    public class Scouting
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public Patient Patient { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public Meal Meals { get; set; } = null!;
        public Medicine Medicines { get; set; } = null!;
        public int Value { get; set; }
        public int RecommendedValue { get; set; }
    }
}