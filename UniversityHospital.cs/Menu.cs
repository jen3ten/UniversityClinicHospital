using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("Welcome to Univserity Hospitals Database!\nWhat would you like to do?\n\n");
            Console.WriteLine(" 1.  Add New Employee");
            Console.WriteLine(" 2.  Pay an Employee");
            Console.WriteLine(" 3.  Check Patient Status");
            Console.WriteLine(" 4.  Check Employee Status");
            Console.WriteLine(" 5.  Payroll");
            Console.WriteLine(" 6.  Quit");
            int menuResponse = Convert.ToInt32(Console.ReadLine());

            switch (menuResponse)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;


            }

        }
        
    }
}
