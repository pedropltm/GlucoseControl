using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GlucoseControl.Models
{
    public class Patient
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Age { get; set; }
    }
}