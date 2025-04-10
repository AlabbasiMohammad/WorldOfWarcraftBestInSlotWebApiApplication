using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace WorldOfWarcraftBestInSlotWebApiApplication.Data
{
    public class PostgresqlDbService : DbContext
    {
        // private readonly IConfiguration _configuration;

        // public PostgresqlDbService(IConfiguration configuration)
        // {
        //     _configuration = configuration;
        // }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     var connectionString = _configuration.GetConnectionString("PostgreSqlConnection");
        //     optionsBuilder.UseNpgsql(connectionString);
        // }

        // public DbSet<YourEntity> YourEntities { get; set; } // Replace with your actual entity


        public PostgresqlDbService(DbContextOptions<PostgresqlDbService> options)
            : base(options)
        {
            
        }
    }

}