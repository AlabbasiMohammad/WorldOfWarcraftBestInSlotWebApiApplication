using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using WorldOfWarcraftBestInSlotWebApiApplication.Models;

namespace WorldOfWarcraftBestInSlotWebApiApplication.Data
{
    public class PostgresqlDbService : DbContext
    {
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemCategory> ItemCategories { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Monster> Monsters { get; set; }


        public PostgresqlDbService(DbContextOptions<PostgresqlDbService> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entities here
            
            // Item
            modelBuilder.Entity<Item>(entity => {

                // many - 1 relationship Item - Category
                entity.HasOne(i => i.Category)
                    .WithMany(c => c.Items)
                    .HasForeignKey(c => c.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);


                // many - 1 relationship Item - Character
                entity.HasOne(i => i.Character)
                    .WithMany(c => c.Items)
                    .HasForeignKey(i => i.CharacterId)
                    .OnDelete(DeleteBehavior.Restrict);


                // 1 - 1 relationship Item - Monster
                entity.HasOne(i => i.Monster)
                    .WithOne(m => m.Item)
                    .HasForeignKey<Monster>(m => m.ItemId)
                    .OnDelete(DeleteBehavior.Restrict);



                // // seed Items
                // entity.HasData(new Item
                // {
                //     Id = 1,
                //     Name = "Ashbringer Sword",
                //     // CategoryId = 1,
                //     Agility = 5,
                //     Strength = 10,
                //     Stamina = 2
                // });
                    

            });
        }
    }
}