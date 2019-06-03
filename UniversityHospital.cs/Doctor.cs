using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Doctor : Employee

    {
        public string SpecialtyArea { get; set; }

        public Doctor()
        {

        }

        public Doctor(string name, int number, string specialty) : base()
        {
            Position = "Doctor";
            Salary = "$90,000";
            SpecialtyArea = specialty;
            Name = name;
            EmployeeNumber = number;
            Payment = false;
        }

        public void DoctorBloodDraw(Hospital hospital)
        {
            foreach (Patient element in hospital.PatientList)
            {
                element.BloodLevel -= 2;
                element.HealthLevel += 3;
            }
        }

        public void DoctorCare(Hospital hospital)
        {
            foreach (Patient element in hospital.PatientList)
            {
                element.BloodLevel += 2;
                element.HealthLevel += 2;

            }
        }



        //public override void PaySalary()
        //{
        //    if (Payment == false)
        //    {
        //        Console.WriteLine($"\tYou have paid {Name} {Salary}");
        //        Payment = true;            
        //    }
        //    else
        //    {
        //        Console.WriteLine($"\t{Name} has already been paid.");
        //    }
        //}
    }
}
