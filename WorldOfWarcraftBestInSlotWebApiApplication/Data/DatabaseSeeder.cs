using System.ComponentModel;
using WorldOfWarcraftBestInSlotWebApiApplication.Models;

namespace WorldOfWarcraftBestInSlotWebApiApplication.Data
{
    public class DatabaseSeeder
    {
        public static async Task Seed(PostgresqlDbService context)
        {
            if (!context.Items.Any())
            {
                var items = new List<Item>
                {
                    // ItemCategory = Weapon
                    new Item { Name = "Ashbringer Sword", Category = new ItemCategory { Name = "Weapon" }, Agility = 5, Strength = 10, Stamina = 2 },
                    new Item { Name = "Frostmourne Sword", Category = new ItemCategory { Name = "Weapon" }, Agility = 7, Strength = 12, Stamina = 3 },
                    new Item { Name = "Thunderfury, Blessed Blade of the Windseeker Sword", Category = new ItemCategory { Name = "Weapon" }, Agility = 10, Strength = 15, Stamina = 5 },

                    // ItemCategory = Armor
                    new Item { Name = "Leggings of the Vanquished Hero", Category = new ItemCategory { Name = "Armor" }, Agility = 8, Strength = 14, Stamina = 4 },
                    new Item { Name = "Breastplate of the Forgotten Vanquisher", Category = new ItemCategory { Name = "Armor" }, Agility = 6, Strength = 11, Stamina = 3 },
                    new Item { Name = "Helm of the Stormwind Champion", Category = new ItemCategory { Name = "Armor" }, Agility = 9, Strength = 13, Stamina = 4 },


                    // ItemCategory = Accessory
                    new Item { Name = "Ring of Eternal Justice", Category = new ItemCategory { Name = "Accessory" }, Agility = 4, Strength = 8, Stamina = 2 },
                    new Item { Name = "Band of the Undying", Category = new ItemCategory { Name = "Accessory" }, Agility = 5, Strength = 9, Stamina = 3 },
                    new Item { Name = "Necklace of the Black Dragonflight", Category = new ItemCategory { Name = "Accessory" }, Agility = 6, Strength = 10, Stamina = 4 },
                    new Item { Name = "Cloak of the Frozen Throne", Category = new ItemCategory { Name = "Accessory" }, Agility = 7, Strength = 11, Stamina = 5 }

                };
                context.Items.AddRange(items);
            }

            // if (!context.Monsters.Any())
            // {
            //     var monsters = new List<Monster>
            //     {
            //         new Monster { Name = "Orc", Item = context.Items.First(i => i.Name == "Ashbringer Sword"), DropItemChance = 0.1m },
            //         new Monster { Name = "Troll", Item = context.Items.First(i => i.Name == "Frostmourne Sword"), DropItemChance = 0.15m },
            //         new Monster { Name = "Goblin", Item = context.Items.First(i => i.Name == "Thunderfury, Blessed Blade of the Windseeker Sword"), DropItemChance = 0.2m },
            //         new Monster { Name = "Dragon", Item = context.Items.First(i => i.Name == "Leggings of the Vanquished Hero"), DropItemChance = 0.25m },
            //         new Monster { Name = "Lich King", Item = context.Items.First(i => i.Name == "Breastplate of the Forgotten Vanquisher"), DropItemChance = 0.3m },
            //         new Monster { Name = "Phoenix", Item = context.Items.First(i => i.Name == "Helm of the Stormwind Champion"), DropItemChance = 0.35m },
            //         new Monster { Name = "Demon", Item = context.Items.First(i => i.Name == "Ring of Eternal Justice"), DropItemChance = 0.4m },
            //         new Monster { Name = "Giant", Item = context.Items.First(i => i.Name == "Band of the Undying"), DropItemChance = 0.45m },
            //         new Monster { Name = "Skeleton", Item = context.Items.First(i => i.Name == "Necklace of the Black Dragonflight"), DropItemChance = 0.5m },
            //         new Monster { Name = "Zombie", Item = context.Items.First(i => i.Name == "Cloak of the Frozen Throne"), DropItemChance = 0.55m }
            //     };
            //     context.Monsters.AddRange(monsters);
            // }

            // add characters
            // if(!context.Characters.Any())
            // {
            //     var characters = new List<Character>
            //     {
            //         new Character { Name = "Arthas Menethil" },
            //     };
            //     context.Characters.AddRange(characters);
            // }

            await context.SaveChangesAsync();
        }
    }
}