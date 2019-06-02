using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Payroll
    {
        public List<Employee> employeeList = new List<Employee>();

        

        Doctor dr1 = new Doctor("Francona, Terry", 8561, "Gastroenterology", "12");
        Doctor dr2 = new Doctor("Roth, Elise", 8213, "Neuro Surgeon", "5");
        Doctor dr3 = new Doctor("Dolson, Miranda", 8497, "Obstetrics\t", "16");
        Doctor dr4 = new Doctor("Sandhu, Cory", 8109, "Pediatrics\t", "11");
        Doctor dr5 = new Doctor("Messaros, Kyle", 8670, "Oncology\t", "8"); 

        //Nurse n1 = new Nurse("Marshall, Ruby", 7512, "--", "21");
        //Nurse n2 = new Nurse("Basiba, John", 7734, "--", "11");
        //Nurse n3 = new Nurse("Kacy, Michael", 7298, "--", "9");
        //Nurse n4 = new Nurse("Maxwell, Linda", 7181, "--", "14");
        //Nurse n5 = new Nurse("Johns, Nicole", 7604, "--", "8");
        //Nurse n6 = new Nurse("Medina, Cindy", 7155, "--", "17");
        //Nurse n7 = new Nurse("Listner, Casey", 7640, "--", "23");
        //Nurse n8 = new Nurse("Masina, Ben ", 7005, "--", "7");
        //Nurse n9 = new Nurse("Richards, Mason", 7371, "--", "20");
        //Nurse n10 = new Nurse("Smith, Jessica", 7492, "--", "13");

        //Janitor j1 = new Janitor("Smith, Matthew", 3561, "\tYes", "N/A");
        //Janitor j2 = new Janitor("Watt, Jonathan", 3213, "\tNo", "N/A");
        //Janitor j3 = new Janitor("Muller, Walter", 3629, "\tNo", "N/A");
        //Janitor j4 = new Janitor("Madison, Jim", 3462, "\tYes", "N/A");
        //Janitor j5 = new Janitor("Harrison, Lloyd", 3901, "\tYes", "N/A");
        //Janitor j6 = new Janitor("Adams, Scott", 3764, "\tNo", "N/A");

        //Receptionist r1 = new Receptionist("Balou, Mary", 1058, "\tNo", "N/A");
        //Receptionist r2 = new Receptionist("Lazara, Kim", 1058, "\tYes", "N/A");





        public void AddEmployeeToList()
        {
            employeeList.Add(dr1);
            employeeList.Add(dr2);
            employeeList.Add(dr3);
            employeeList.Add(dr4);
            employeeList.Add(dr5);
            //employeeList.Add(n1);
            //employeeList.Add(n2);
            //employeeList.Add(n3);
            //employeeList.Add(n4);
            //employeeList.Add(n5);
            //employeeList.Add(n6);
            //employeeList.Add(n7);
            //employeeList.Add(n8);
            //employeeList.Add(n9);
            //employeeList.Add(n10);
            //employeeList.Add(j1);
            //employeeList.Add(j2);
            //employeeList.Add(j3);
            //employeeList.Add(j4);
            //employeeList.Add(j5);
            //employeeList.Add(j6);
            //employeeList.Add(r1);
            //employeeList.Add(r2);
        }

        public void EmployeeList()
        {
            Console.WriteLine("\n\tEmployee List:\n");
            Console.WriteLine("Employee Name\t | Position\t|  Number |  Salary\t| # of Patients |");
            Console.WriteLine("-----------------|--------------|---------|-------------|---------------|");

            foreach (Employee element in employeeList)
            {
                Console.WriteLine($"{element.Name}\t | {element.Position}\t|  {element.EmployeeNumber}   | {element.Salary}\t|\t{element.NumberOfPatients}\t|");
            }
            Console.WriteLine(" ");
        }

        public void DoctorList()
        {

            Console.WriteLine("\n\tDoctor List:\n");
            Console.WriteLine("EmployeeName\t  | Number | Specialty\t\t| # of Patients |");
            Console.WriteLine("------------------|--------|--------------------|---------------|");
         
            foreach (Doctor element in employeeList) //This causes the program to crash once it reaches the janitor values
            {
                Console.WriteLine($"{element.Name}\t  |  {element.EmployeeNumber}  | \t| {element.NumberOfPatients} \t\t|");
            }
            Console.WriteLine(" ");
            Console.ReadLine();


        }

    }
}
