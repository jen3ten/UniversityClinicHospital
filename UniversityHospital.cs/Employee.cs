using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public string Salary { get; set; }
        public string Position { get; set; }
        public string NumberOfPatients { get; set; }
        public bool Payment { get; set; }

        public abstract void PaySalary();
        public abstract void BloodDraw();
        public abstract void CarePatient();

        //public int ChooseEmployeeType()
        //{
        //    //Make switch case with default...later
        //    Console.WriteLine("Choose an employee position");
        //    return Convert.ToInt32(Console.ReadLine();
        //}
    }
}
