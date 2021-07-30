using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;

namespace UniversityApp.Impl
{
    public class Course:Entity
    {
        //PROPERTIES
        public string Code { get; set; }
        public string Subject { get; set; }
        public CourseCategoryEnum Category { get; set; }
        public int Hours { get; set; }

        public Course()
        {

        }
    }
}
