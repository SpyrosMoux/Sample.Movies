using Microsoft.EntityFrameworkCore;
using Sample.Movies.Api.Models;

namespace Sample.Movies.Api.Db;

public class AppDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite($"Data Source=./db/movies.db");
}