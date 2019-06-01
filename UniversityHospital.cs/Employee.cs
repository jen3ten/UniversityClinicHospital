using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public int Salary { get; set; }
        public string Position

        public Employee(string name, int number, string position)
        {
            Name = name;
            EmployeeNumber = number;
            Position = position;
        }

    }
}
