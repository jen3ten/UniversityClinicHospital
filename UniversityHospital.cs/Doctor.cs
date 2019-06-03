using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Doctor : Employee

    {
        public string SpecialtyArea { get; set; }

        public Doctor(string name, int number, string specialty) : base()
        {
            Position = "Doctor";
            Salary = "$90,000";
            SpecialtyArea = specialty;
            Name = name;
            EmployeeNumber = number;
            Payment = false;
        }

        public override void PaySalary()
        {
            if (Payment == false)
            {
                Console.WriteLine($"\tYou have paid {Name} {Salary}");
                Payment = true;            
            }
            else
            {
                Console.WriteLine($"\t{Name} has already been paid.");
            }
        }


    }

}
