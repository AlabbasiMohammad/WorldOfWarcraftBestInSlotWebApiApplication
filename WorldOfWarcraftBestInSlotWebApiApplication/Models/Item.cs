namespace WorldOfWarcraftBestInSlotWebApiApplication.Models
{

    public enum ItemCategory
    {
        Armor,
        Weapon,
        Accessory
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Agility { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public ItemCategory Category { get; set; }

        // ToDo : add item drop chance
        
    }
}
