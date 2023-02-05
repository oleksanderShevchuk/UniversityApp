using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    internal class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Student> Students { get; set; } = null!;
        public Faculty Faculty { get; set; } = null!; 
    }
}
