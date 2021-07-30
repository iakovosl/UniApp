﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Base;

namespace UniversityApp.Impl
{
    public class Schedule : Entity
    {
        public string Student { get; set; }
        public string Professor { get; set; }
        public string Course { get; set; }
        public DateTime Calendar { get; set; }

        public Schedule()
        {

        }
    }
}
