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
            (Payment)//making a random comment to push
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

        public void BloodDraw()
        {
            patient.BloodLevel-=2;
            patient.HealthLevel+=3;
            Console.WriteLine("Blood sample has been drawn and sent to the lab for testing.");
        }

        public void CarePatient()
        {
            patient.BloodLevel+=2;
            patient.HealthLevel+=2;
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
