using MongoDB.Bson.Serialization.Attributes;

namespace WorldOfWarcraftBestInSlotWebApiApplication.Models
{
    public class Monster
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<DropInfo> ItemDrops { get; set; } = new ();
    }
}
