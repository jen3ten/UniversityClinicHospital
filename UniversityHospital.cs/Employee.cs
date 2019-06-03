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

        //public abstract void PaySalary();
        public void PaySalary()
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


    }
}
