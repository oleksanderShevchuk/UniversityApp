namespace UniversityApp.Models
{
    internal class Teacher : Person
    {
        public University? University { get; set; }
        public List<Lesson>? Lessons { get; set; }
        public int Selery { get; set; }
    }
}
