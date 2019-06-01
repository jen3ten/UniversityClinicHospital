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
        Doctor dr5 = new Doctor("Messaros, Kyle", 8670, "Funcitonal Medicine", "8");
        Janitor j1 = new Janitor("Smith, Matthew", 3561, "\tYes");
        Janitor j2 = new Janitor("Watt, Jonathan", 3213, "\tNo");

        public void AddEmployeeToList()
        {
            employeeList.Add(dr1);
            employeeList.Add(dr2);
            employeeList.Add(dr3);
            employeeList.Add(dr4);
            employeeList.Add(dr5);
            //employeeList.Add(j1);
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
            Console.WriteLine("------------------|--------|----------------------|---------------|");

            int i = 1;
            foreach (Doctor element in employeeList)
            {
                Console.WriteLine($"{element.Name}\t  |  {element.EmployeeNumber}  |  {element.SpecialtyArea}\t| {element.NumberOfPatients} \t\t|");
            }
            Console.WriteLine(" ");
        }

    }
}
