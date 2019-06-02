using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Receptionist : Employee
    {

        public string OnPhone { get; set; }

        public Receptionist(string name, int number, string phone, string patientNumber) : base()
        {
            Name = name;
            EmployeeNumber = number;
            Salary = "$45,000";
            OnPhone = phone;
            Position = "Receptionist";
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
        }
        public override void CarePatient()
        {
        }

    }
}
