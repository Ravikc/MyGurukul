using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGurukul.Models;

namespace MyGurukul.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {

        public DbSet<Student> Student { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Alert> Alert { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Complaint> Complaint { get; set; }
        public DbSet<CurrentSubject> CurrentSubject { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<TimeTable> TimeTable { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<MentorAllotment> MentorAllotment { get; set; }
        public DbSet<ProgramOutcome> ProgramOutcome { get; set; }
        public DbSet<CourseOutcome> CourseOutcome { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Student>().HasIndex(i => i.USN).IsUnique();
        }
    }
}
