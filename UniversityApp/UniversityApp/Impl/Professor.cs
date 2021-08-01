using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;

namespace UniversityApp.Impl
{
   public class Professor:Person
    {
        public string Rank { get; set; }
        public List<CourseCategoryEnum> CanTeach { get; set; }

        public Professor()
        {

        }
    }
}
