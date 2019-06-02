using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Doctor : Employee

    {

        public string SpecialtyArea { get; set; }

        public Doctor(string name, int number, string specialty, string patientNumber) : base()
        {
            Position = "Doctor";
            Salary = "$90,000";
            SpecialtyArea = specialty;
            Name = name;
            EmployeeNumber = number;
            NumberOfPatients = patientNumber;
            //SalaryPaid = false;
        }

        
    }
}
