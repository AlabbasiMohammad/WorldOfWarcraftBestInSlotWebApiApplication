using MongoDB.Bson.Serialization.Attributes;

namespace WorldOfWarcraftBestInSlotWebApiApplication.Models
{
    public class Character
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    }
}
