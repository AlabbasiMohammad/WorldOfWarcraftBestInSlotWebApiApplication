namespace WorldOfWarcraftBestInSlotWebApiApplication.Models
{
    public class ItemCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ItemId { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Agility { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int CategoryId { get; set; }
        public virtual ItemCategory Category { get; set; }

        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }


        public int MonsterId { get; set; }
        public virtual Monster Monster { get; set; }
        
    }
}
