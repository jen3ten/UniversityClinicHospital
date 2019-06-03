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


        //**********
        //public Doctor ChooseEmployee(Payroll payroll)
        //{
        //    int i = 0;
        //    foreach (var employee in payroll.doctorList)
        //    {
        //        i = i + 1;
        //        Console.WriteLine($"{i}. {employee.Name}");
        //    }
        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    choice--;
        //    Console.WriteLine($"You have chosen {payroll.doctorList[choice].Name}");
        //    return payroll.doctorList[choice];
        //}
    }

}
