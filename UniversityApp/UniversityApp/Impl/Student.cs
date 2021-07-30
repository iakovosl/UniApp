using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;

namespace UniversityApp.Impl
{
   public class Student:Person
    {
        public int RegistrationNumber { get; set; }
        public List<CourseCategoryEnum> CanLearn { get; set; }

        public Student()
        {

        }
    }
}
