using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Employee
    {
        Patient patient;
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public string Salary { get; set; }
        public string Position { get; set; }
        public string SalaryPaid { get; set; }
        public string NumberOfPatients { get; set; }

    }
}
