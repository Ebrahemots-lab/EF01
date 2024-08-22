using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Bouns { get; set; }

        public int Salray { get; set; }

        public string Adress { get; set; }

        public int HourRate { get; set; }

        public int Dept_Id { get; set; }
    }
}
