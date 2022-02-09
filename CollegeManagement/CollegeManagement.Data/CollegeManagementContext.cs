using CollegeManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CollegeManagement.Data
{
    public class CollegeManagementContext : DbContext
    {
        public CollegeManagementContext(DbContextOptions<CollegeManagementContext> options)
            : base(options)
        {
        }

        public DbSet<College> Colleges { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
 