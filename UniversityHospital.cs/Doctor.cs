using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Doctor : Employee

    {
        Patient patient;

        public string SpecialtyArea { get; set; }

        public Doctor(string name, int number, string specialty, string patientNumber) : base()
        {
            Position = "Doctor";
            Salary = "$90,000";
            SpecialtyArea = specialty;
            Name = name;
            EmployeeNumber = number;
            NumberOfPatients = patientNumber;
            Payment = false;
        }

        public override void PaySalary()
        {
            if (Payment == false)
            {
                Console.WriteLine($"You have paid {Name} {Salary}");
                Payment = true;            
            }
            else
            {
                Console.WriteLine($"{Name} has already been paid.");
            }
        }

        public override void BloodDraw()
        {
            patient.BloodLevel-=2;
            patient.HealthLevel+=3;
        }

        public override void CarePatient()
        {
            patient.BloodLevel+=2;
            patient.HealthLevel+=2;
        }



    }
}
