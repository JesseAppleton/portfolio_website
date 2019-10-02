using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) { }
        
        // public DbSet<User> Users { get; set; }
        // public DbSet<Party> Parties { get; set; }
        // public DbSet<Join> Joins { get; set; }
    }
}