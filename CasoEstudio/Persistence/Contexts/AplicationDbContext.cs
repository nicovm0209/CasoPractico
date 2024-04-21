using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class AplicationDbContext : DbContext, IAplicationDbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
