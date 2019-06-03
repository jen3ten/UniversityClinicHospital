using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Nurse : Employee
    {
        public string SpecialtyArea { get; set; }

        public Nurse()
        {

        }

        public Nurse(string name, int number, string specialty, string patientNumber) : base()
        {
            Position = "Nurse";
            Salary = "$50,000";
            SpecialtyArea = specialty;
            Name = name;
            EmployeeNumber = number;
            NumberOfPatients = patientNumber;
            Payment = false;
        }

        public void NurseCare(Hospital hospital)
        {

            foreach (Patient element in hospital.PatientList)
            {
                element.BloodLevel++;
                element.HealthLevel++;
            }
        }

        public void NurseBloodDraw(Hospital hospital)
        {
            foreach (Patient element in hospital.PatientList)
            {
                element.BloodLevel--;
                element.HealthLevel++;
            }
        }



        //public override void PaySalary()
        //{
        //    if (Payment == false)
        //    {
        //        Console.WriteLine($"You have paid {Name} {Salary}");
        //        Payment = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Name} has already been paid.");
        //    }
        //}
    }
}
