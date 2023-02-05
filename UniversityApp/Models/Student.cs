using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    internal class Student : Person
    {
        public University? University { get; set; }
        public List<Lesson> Lessons { get; set; } = new();
        public Specialty Specialty { get; set; } = null!;
    }
}
