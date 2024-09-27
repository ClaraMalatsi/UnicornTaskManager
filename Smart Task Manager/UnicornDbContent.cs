using Microsoft.EntityFrameworkCore;
using UnicornTaskManager.Models;

namespace UnicornTaskManager.Data
{
    public class UnicornDbContext : DbContext
    {
        public UnicornDbContext(DbContextOptions<UnicornDbContext> options) : base(options) { }

        public DbSet<UnicornTask> UnicornTasks { get; set; }
    }
    
}
