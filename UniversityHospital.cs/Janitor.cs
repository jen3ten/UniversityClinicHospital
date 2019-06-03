﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
   public class Janitor : Employee 
    {
        public string Sweep { get; set; }

        public Janitor(string name, int number, string sweep) : base()
        {
            Name = name;
            EmployeeNumber = number;
            Salary = "$40,000";
            Sweep = sweep;
            Position = "Janitor";
            Payment = false;
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

