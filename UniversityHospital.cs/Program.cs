using System;

namespace UniversityHospital.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MainMenu();

            Payroll payroll = new Payroll();
            payroll.AddDoctorToList();
            payroll.AddNurseToList();
            payroll.AddJanitorToList();
            payroll.AddReceptionistToList();


        }
    }
}
