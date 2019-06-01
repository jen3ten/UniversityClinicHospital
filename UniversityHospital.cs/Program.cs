using System;

namespace UniversityHospital.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("");
            employee.name(); 
            Menu menu = new Menu();
            menu.MainMenu();
        }
    }
}
