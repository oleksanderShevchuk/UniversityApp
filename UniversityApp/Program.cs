using UniversityApp.Data;
using UniversityApp.Models;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var Dean = new Dean() { Name = "Vladyslav Yosypovych" };
                db.Deans.Add(Dean);
                var lesson1 = new Lesson() { Name = "Programming" };
                var lesson2 = new Lesson() { Name = "Physics" };
                var lesson3 = new Lesson() { Name = "Math" };
                db.Lessons.AddRange(lesson1, lesson2, lesson3);

                var student1 = new Student
                {
                    Name = "Oleg",
                    Lessons = new List<Lesson> { lesson1, lesson2 },
                };
                var student2 = new Student
                {
                    Name = "Anna",
                    Lessons = new List<Lesson> { lesson2 },
                };
                var student3 = new Student
                {
                    Name = "Roma",
                    Lessons = new List<Lesson> { lesson2, lesson3 },
                };
                db.Students.AddRange(student1, student2, student3);

                var stuff1 = new Stuff
                {
                    Name = "Physics",
                    Selery = 250,
                };
                var stuff2 = new Stuff
                {
                    Name = "Mathematicians",
                    Selery = 255,
                };
                var stuff3 = new Stuff
                {
                    Name = "Programmers",
                    Selery = 300,
                };
                db.Stuffs.AddRange(stuff1, stuff2, stuff3);

                var teacher1 = new Teacher
                {
                    Name = "Petro Georgiyovych",
                    Lessons = new List<Lesson> { lesson1 },
                    Selery = 200,
                };
                var teacher2 = new Teacher
                {
                    Name = "Oksana Vasylivna",
                    Lessons = new List<Lesson> { lesson2, lesson3 },
                    Selery = 220,
                };
                var teacher3 = new Teacher
                {
                    Name = "Vladyslav Yosypovych",
                    Lessons = new List<Lesson> { lesson3 },
                    Selery = 250,
                };
                db.Teachers.AddRange(teacher1, teacher2, teacher3);

                var specialty1 = new Specialty
                {
                    Name = "КІ",
                    Students = new List<Student> { student1, student2 },
                };
                var specialty2 = new Specialty
                {
                    Name = "КН",
                    Students = new List<Student> { student3 },
                };
                db.Specialties.AddRange(specialty1, specialty2);

                var faculty1 = new Faculty
                {
                    Name = "Computer Science",
                    Dean = Dean,
                    Specialtys = new List<Specialty> { specialty1 },
                };
                var faculty2 = new Faculty
                {
                    Name = "Computer Engineering",
                    Dean = Dean,
                    Specialtys = new List<Specialty> { specialty2 },
                };
                db.Faculties.AddRange(faculty1, faculty2);


                var university = new University()
                {
                    Name = "MY University",
                    Faculties = new List<Faculty> { faculty1, faculty2 },
                    Specialties = new List<Specialty> { specialty1, specialty2 },
                    Students = new List<Student> { student1, student2, student3 },
                    Stuffs = new List<Stuff> { stuff1, stuff2 },
                    Teachers = new List<Teacher> { teacher1, teacher2, teacher3 },
                };
                db.Universities.Add(university);
                db.SaveChanges();
            }

            

        }
    }
}