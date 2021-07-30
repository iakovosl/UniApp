using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl
{
   public class University
    {
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }

        public void UniversityData()
        {
            Courses.Add(new Course()
            {
                Code = "1",
                Subject = "Quantum Physics",
                Category = CourseCategoryEnum.Physics,
                Hours = 100
            });

            Courses.Add(new Course()
            {
                Code = "2",
                Subject = "Electo-Dynamics",
                Category = CourseCategoryEnum.Physics, // physics ?
                Hours = 50
            });

            Courses.Add(new Course()
            {
                Code = "3",
                Subject = "Basic Chemistry",
                Category = CourseCategoryEnum.Chemistry,
                Hours = 50
            });

            Courses.Add(new Course()
            {
                Code = "4",
                Subject = "Financial II",
                Category = CourseCategoryEnum.Financial,
                Hours = 50
            });

            Courses.Add(new Course()
            {
                Code = "5",
                Subject = "Mathematics I",
                Category = CourseCategoryEnum.Mathematics,
                Hours = 50
            });

            Students.Add(new Student()
            {

                Name = "Fotis",
                Surname = "Chrysoulas",
                RegistrationNumber = 1234,
                Age = 21,
                CanLearn = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });


            Students.Add(new Student()
            {

                Name = "Dimitris",
                Surname = "Raptodimos",
                RegistrationNumber = 1235,
                Age = 23,
                CanLearn = new List<CourseCategoryEnum>() { CourseCategoryEnum.Physics, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor()
            {
                Name = "Maria",
                Surname = "Papadopoulou",
                Age = 33,
                Rank = "1",
                CanTeach = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor()
            {
                Name = "Eirini",
                Surname = "Papa",
                Age = 36,
                Rank = "2",
                CanTeach = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor()
            {
                Name = "Sofia",
                Surname = "Papadopoulou",
                Age = 33,
                Rank = "3",
                CanTeach = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor()
            {
                Name = "Nikos",
                Surname = "Papas",
                Age = 33,
                Rank = "4",
                CanTeach = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });
        }
    }
}
