﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Student
    {
        public int Id { get; set; }

        public string Fname { get; set; }

        public string? Lname { get; set; }

        public int Age { get; set; }

        public int Dept_Id { get; set; }
    }
}
