using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;
using System.Reflection.Metadata;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Division> Divisions { get; set; }

        public DbSet<Station> Stations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");

            modelBuilder.Entity<Course>()
             .Property(b => b.CreatedDate)
             .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Course>()
           .Property(b => b.CreatedBy)
           .HasDefaultValue("admin");
        }

        //public DbSet<ContosoUniversity.Models.Student> Student { get; set; } = default!;
    }
}
