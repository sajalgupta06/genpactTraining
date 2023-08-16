using Microsoft.EntityFrameworkCore;
using ourApp4.Models;

namespace ourApp4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course{ CourseId = 1, CName = "Dot Net", CFee = 12000, Status = true, Technology = "c#" }
                )
                ;
        }
    }
}
