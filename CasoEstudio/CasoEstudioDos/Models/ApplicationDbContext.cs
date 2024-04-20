using Microsoft.EntityFrameworkCore;

namespace CasoEstudioDos.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }   

        public DbSet<Comment> Comments { get; set; }
    }
}
