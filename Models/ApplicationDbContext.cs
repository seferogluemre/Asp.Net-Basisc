using Microsoft.EntityFrameworkCore;

namespace UserManagementApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    
        public DbSet<User> Users { get; set; }
    }
}
