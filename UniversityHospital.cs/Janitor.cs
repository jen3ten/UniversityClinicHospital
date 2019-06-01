using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
   public class Janitor : Employee 
    {
        public string Sweep { get; set; }

        public Janitor(string name, int number, string sweep) : base()
        {
            Name = name;
            EmployeeNumber = number;
            Salary = 40000;
            Sweep = sweep;
            Position = "Janitor";
        }
    }
}
