using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Models
{
    internal class University
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Student> Students { get; set; } = new();
        public List<Teacher> Teachers { get; set; } = new();
        public List<Stuff> Stuffs { get; set; } = new();
        public List<Faculty> Faculties { get; set; } = new();
        public List<Specialty> Specialties { get; set; } = new();

    }
}
