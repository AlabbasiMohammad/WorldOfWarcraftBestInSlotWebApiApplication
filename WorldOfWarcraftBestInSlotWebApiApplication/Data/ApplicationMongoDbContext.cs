using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WorldOfWarcraftBestInSlotWebApiApplication.Models;

namespace WorldOfWarcraftBestInSlotWebApiApplication.Data
{
    public class ApplicationMongoDbContext
    {
        private readonly IMongoDatabase _database;
        public ApplicationMongoDbContext(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<Item> Items => _database.GetCollection<Item>("Items");
        public IMongoCollection<Character> Characters => _database.GetCollection<Character>("Characters");
        public IMongoCollection<Monster> Monsters => _database.GetCollection<Monster>("Monsters");

    }



    public class MongoDbSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }

    
}
