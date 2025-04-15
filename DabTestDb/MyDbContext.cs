using DabDbTestDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DabDbTestDb;

public class MyDbContext : DbContext
{
    // define the models
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public MyDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // var connectionString = config.GetConnectionString("MyDbConnectionString");
        var connectionString = "Server=localhost,1433;Database=DabTestDb;User Id=SA;Password=Ginpass123!;TrustServerCertificate=true;";

        if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException("My db connection string is required");
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}