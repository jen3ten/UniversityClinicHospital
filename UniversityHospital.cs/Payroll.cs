using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    class Payroll
    {
        Employee employee;
        public List<Employee> employeeList = new List<Employee>();

        Doctor dr1 = new Doctor("Francona, Terry", 8561, "Gastroenterology", "12");
        Doctor dr2 = new Doctor("Roth, Elise", 8213, "Neuro Surgeon", "5");
        Doctor dr3 = new Doctor("Dolson, Miranda", 8497, "Obstetrics\t", "16");
        Doctor dr4 = new Doctor("Sandhu, Cory", 8109, "Pediatrics\t", "11");
        Doctor dr5 = new Doctor("Messaros, Kyle", 8670, "Oncology\t", "8");


        Nurse n1 = new Nurse("Marshall, Ruby", 7512, "--", "21");
        Nurse n2 = new Nurse("Basiba, John", 7734, "--", "11");
        Nurse n3 = new Nurse("Kacy, Michael", 7298, "--", "9");
        Nurse n4 = new Nurse("Maxwell, Linda", 7181, "--", "14");
        Nurse n5 = new Nurse("Johns, Nicole", 7604, "--", "8");
        Nurse n6 = new Nurse("Medina, Cindy", 7155, "--", "17");
        Nurse n7 = new Nurse("Listner, Casey", 7640, "--", "23");

        Janitor j1 = new Janitor("Smith, Matthew", 3561, "\tYes");
        Janitor j2 = new Janitor("Watt, Jonathan", 3213, "\tNo");
        Janitor j3 = new Janitor("Muller, Walter", 3629, "\tNo");
        Janitor j4 = new Janitor("Madison, Jim", 3462, "\tYes");
        Janitor j5 = new Janitor("Harrison, Lloyd", 3901, "\tNo");

        public void AddEmployeeToList()
        {
            employeeList.Add(dr1);
            employeeList.Add(dr2);
            employeeList.Add(dr3);
            employeeList.Add(dr4);
            employeeList.Add(dr5);
            employeeList.Add(n1);
            employeeList.Add(n2);
            employeeList.Add(n3);
            employeeList.Add(n4);
            employeeList.Add(n5);
            employeeList.Add(n6);
            employeeList.Add(n7);
            employeeList.Add(j1);
            employeeList.Add(j2);
            employeeList.Add(j3);
            employeeList.Add(j4);
            employeeList.Add(j5);
        }

        public void EmployeeList()
        {
            Console.WriteLine("\n\tEmployee List:\n");
            Console.WriteLine("Employee Name\t | Position\t|  Number |  Salary\t| # of Patients |");
            Console.WriteLine("-----------------|--------------|---------|-------------|---------------|");
            foreach (Doctor element in employeeList)
            {
                Console.WriteLine($"{element.Name}\t | {element.Position}\t|  {element.EmployeeNumber}   | {element.Salary}\t|\t{element.NumberOfPatients}\t|");
            }
            foreach (Employee element in employeeList)
            {

            }
            Console.WriteLine(" ");
        }

        public void NurseList()
        {
            employee = new Employee();
            Console.WriteLine("\n\tDoctor List:\n");
            Console.WriteLine("EmployeeName\t  | Number | Specialty\t\t| # of Patients |");
            Console.WriteLine("------------------|--------|--------------------|---------------|");
            foreach (Employee element in employeeList)
            {
                if (element.Position == "Nurse")
                {
                    Console.WriteLine($"{element.Name}\t | {element.Position}\t|  {element.EmployeeNumber}   | {element.Salary}\t|\t{element.NumberOfPatients}\t|");

                }
                else
                {
                }


            }
        }


        public void DoctorList()

        {
            Console.WriteLine("\n\tDoctor List:\n");
            Console.WriteLine("EmployeeName\t  | Number | Specialty\t\t| # of Patients |");
            Console.WriteLine("------------------|--------|--------------------|---------------|");
            if (employee.Position == "Nurse")
            {

            }

            foreach (Employee doctor in employeeList)

            {
                Console.WriteLine($"{doctor.Position} {doctor.Name}\t  |  {doctor.EmployeeNumber}  | \t| {doctor.NumberOfPatients} \t\t|");

            }

            Console.WriteLine(" ");
        }

    }

}

