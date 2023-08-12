using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DbManager : DbContext
    {
        public DbManager(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
