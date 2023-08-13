using ClientApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClientApp.Data;

public class DbManager : DbContext
{
    public DbManager(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
}
