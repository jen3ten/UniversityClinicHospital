using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Nurse : Employee
    {
        public string SpecialtyArea { get; set; }

        public Nurse(string name, int number, string specialty, string patientNumber) : base()
        {
            Position = "Nurse";
            Salary = "$50,000";
            SpecialtyArea = specialty;
            Name = name;
            EmployeeNumber = number;
            NumberOfPatients = patientNumber;
            //SalaryPaid = false;
        }


    }
}
