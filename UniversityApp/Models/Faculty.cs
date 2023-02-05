using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Models
{
    internal class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public University University { get; set; } = null!;
        public List<Specialty> Specialtys { get; set; } = new ();
        public Dean Dean { get; set; } = null!;
    }
}
