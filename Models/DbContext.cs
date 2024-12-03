using Microsoft.EntityFrameworkCore;

namespace final.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    public DbSet<Anime> Animes {get; set;} = default!;
    public DbSet<Character> Characters {get; set;} = default!;
}