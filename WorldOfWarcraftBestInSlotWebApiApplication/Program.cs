using Microsoft.EntityFrameworkCore;
using WorldOfWarcraftBestInSlotWebApiApplication.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.Configure<MongoDbSettings>(
//     builder.Configuration.GetSection("MongoDbSettings"));
// builder.Services.AddSingleton<ApplicationMongoDbContext>();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<PostgresqlDbService>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresqlDbConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// using (var scope = app.Services.CreateScope())
// {
//     var dbContext = scope.ServiceProvider.GetRequiredService<PostgresqlDbService>();
//     // await dbContext.Database.EnsureCreatedAsync();
//     await DatabaseSeeder.Seed(dbContext);
// }

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
