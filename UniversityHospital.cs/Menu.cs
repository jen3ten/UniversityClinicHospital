using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Menu
    {
        bool start = true;
        Payroll payroll;


        public void MainMenu()
        {
            Console.WriteLine("Welcome to Univserity Hospitals Database!");

            do
            {
                Console.WriteLine("What would you like to do?\n\n");
                Console.WriteLine(" 1.  Add New Employee");
                Console.WriteLine(" 2.  Fire an Employee");
                Console.WriteLine(" 3.  Pay an Employee");
                Console.WriteLine(" 4.  Check Patient Status");
                Console.WriteLine(" 5.  Check Employee Status");
                Console.WriteLine(" 6.  Payroll");
                Console.WriteLine(" 7.  Quit");
                int menuResponse = Convert.ToInt32(Console.ReadLine());

<<<<<<< HEAD
                payroll = new Payroll(); //I think this is where we need to reference it to get the add list method to work, but I'm still having trouble getting it to run

=======
>>>>>>> 4db8bf5285a5773e8c437b21711b1a8f49d848f1
                if (menuResponse.Equals(7))
                {
                    start = false;
                }

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
                        payroll.EmployeeList();
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Please enter a value between \"1\" and \"6\"");
                        break;
                }
                Console.Clear();
            } while (start);
        }

    }
        
}
