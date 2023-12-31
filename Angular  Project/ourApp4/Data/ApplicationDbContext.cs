﻿using Microsoft.EntityFrameworkCore;
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
   new Course { CourseId = 1, CName = "Dot Net", CFee = 12000, Status = true, Technology = "c#" },
   new Course { CourseId = 2, CName = "Java", CFee = 14000, Status = true, Technology = "Java" },
   new Course { CourseId = 3, CName = "Python", CFee = 10000, Status = true, Technology = "Python" },
   new Course { CourseId = 4, CName = "React", CFee = 22000, Status = false, Technology = "Javascript" }
                )
                ;
        }
    }
}
