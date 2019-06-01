using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Payroll
    {
        public List<Employee> employeeList = new List<Employee>();

        Doctor dr1 = new Doctor("Francona, Terry", 8561, "Gastro");
        Doctor dr2 = new Doctor("Roth, Elise", 8213, "Neuro Surgeon");
        Doctor dr3 = new Doctor("Dolson, Miranda", 8497, "OB/GYN");
        Doctor dr4 = new Doctor("Sandhu, Cory", 8109, "Pediatrics");
        Doctor dr5 = new Doctor("Messaros, Kyle", 8670, "Funcitonal Medicine");
        Janitor j1 = new Janitor("Lawrence, Matthew\t", 3561, "\tYes");
        Janitor j2 = new Janitor("Watt, Jonathan\t", 3213, "\tNo");

        public void AddEmployeeToList()
        {
            employeeList.Add(dr1);
            employeeList.Add(dr2);
            employeeList.Add(dr3);
            employeeList.Add(dr4);
            employeeList.Add(dr5);
            employeeList.Add(j1);
        }

        public void EmployeeList()
        {
            Console.WriteLine("\t\tEmployee List:\n");
            foreach (Employee element in employeeList)
            {
                Console.WriteLine($"{element.Name} | {element.Position} | {element.EmployeeNumber} | {element.Salary} | ");
            }
        }

    }
}
