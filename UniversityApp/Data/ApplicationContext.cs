using Microsoft.EntityFrameworkCore;
using UniversityApp.Models;

namespace UniversityApp.Data
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext() { }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Dean> Deans { get; set; }
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<University> Universities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UniversityApp;Trusted_Connection=True;");
            
        }
        
    }
}
