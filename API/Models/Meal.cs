using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GlucoseControl.Models
{
    public class Meal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        public string? Description { get; set; }
    }
}