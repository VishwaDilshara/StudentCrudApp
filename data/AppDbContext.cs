using Microsoft.EntityFrameworkCore;
using StudentCrudApp.Models;

namespace StudentCrudApp.Data
{
    public class AppDbContext : DbContext //inherit DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
