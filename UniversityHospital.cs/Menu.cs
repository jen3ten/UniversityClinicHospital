using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Menu
    {
        bool start = true;
        Payroll payroll;
        Doctor doctor;



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
                Console.WriteLine(" 5.  Supervise Employee");
                Console.WriteLine(" 6.  Payroll");
                Console.WriteLine(" 7.  Quit");
                int menuResponse = Convert.ToInt32(Console.ReadLine());

                int menuResponse2 = Convert.ToInt32(Console.ReadLine());

                //int menuResponse3 = Convert.ToInt32(Console.ReadLine());

                // STILL WORKING ON THIS, NEEDED TO REARRANGE SOME THINGS TO HAVE LIST MAKE SENSE. 

                payroll = new Payroll(); //I think this is where we need to reference it to get the add list method to work, but I'm still having trouble getting it to run


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
                        payroll.AddReceptionistToList();
                        payroll.AddJanitorToList();
                        break;
                        //Non patient
                    case 4:
                         
                        break;
                        //Patient 
                    case 5:
                        switch (menuResponse2)
                        {
                            case 1://select a Doctor or Nurse to take care of patient
                                Console.WriteLine("Select a Doctor or Nurse to take care of patient");
                                payroll.DoctorList();
                                payroll.AddNurseToList();
                                payroll.EmployeeList();
                                break;
                            case 2://Avaliability of Recep or Jan
                        payroll.JanitorAndReceptionList();
                                Console.WriteLine("");
                                break;

                        }
                        //payroll.AddDoctorToList();
                        break;
                        //payroll.AddNurseToList();
                        //payroll.DoctorList();
                
                    case 6:
                        payroll.AddDoctorToList();
                        payroll.AddJanitorToList();
                        payroll.AddNurseToList();
                        payroll.AddReceptionistToList();
                        payroll.EmployeeList();
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Please enter a value between \"1\" and \"6\"");
                        break;
                }
            } while (start);
        }

    }
        
}
