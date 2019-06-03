using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Menu
    {

        public void MainMenu()
        {
            bool start = true;

            Patient patient = new Patient("", 0);
            Payroll payroll = new Payroll();
            Console.WriteLine("Welcome to Univserity Hospitals Database!");

            payroll.AddPatientToList();
            payroll.AddReceptionistToList();
            payroll.AddNurseToList();
            payroll.AddJanitorToList();
            payroll.AddDoctorToList();


            do
            {
                Console.WriteLine("What would you like to do?\n\n");
                Console.WriteLine(" 1.  View Patient List");
                Console.WriteLine(" 2.  //Fire an Employee//");
                Console.WriteLine(" 3.  View Employee Lists");
                Console.WriteLine(" 4.  Medical Task");
                Console.WriteLine(" 5.  Payroll");
                Console.WriteLine(" 6.  Done");
                int menuResponse = Convert.ToInt32(Console.ReadLine());
                //int menuResponse3 = Convert.ToInt32(Console.ReadLine());
                // STILL WORKING ON THIS, NEEDED TO REARRANGE SOME THINGS TO HAVE LIST MAKE SENSE. 

                switch (menuResponse)
                {
                    case 1:
                        payroll.PatientList();
                        break;
                    case 2:
                        payroll.EmployeeList();
                        Console.WriteLine("Which employee will be let go?");
                        int menuResponse5 = Convert.ToInt32(Console.ReadLine());
                        switch (menuResponse5)
                        {
                            case 1:
                                break;
                        }

                        break;

                    case 3://Inform Doctor or Nurse of Patient Need
                        Console.WriteLine("1. Inform Doctor or Nurse of Patient Need\n" +
                                          "2. Review Receptionists and Janitors' Status'");

                        int menuResponse2 = Convert.ToInt32(Console.ReadLine());
                        switch (menuResponse2)
                        {
                            case 1://select a Doctor or Nurse to take care of patient
                                payroll.DoctorAndNurseList();
                                Console.WriteLine("These are the Doctors and Nurses currently avaliable.\n" +
                                                    "Select a Doctor or Nurse to draw blood sample");

                                int menuResponse3 = Convert.ToInt32(Console.ReadLine());
                                switch (menuResponse3)
                                {
                                    case 1://Select Patient
                                        payroll.PatientList();              
                                        Console.WriteLine("Which patient should be assisted?");
                                        //Create index to select from Doctor and Nurse List

                                        int menuResponse4 = Convert.ToInt32(Console.ReadLine());
                                            switch (menuResponse4)
                                            {
                                                case 1:// Draw blood

                                                    break;
                                                case 2://Care for
                                                    break;
                                                default:
                                                    Console.WriteLine("Please enter either \"1\" or \"2\".");
                                                    break;
                                            }break;
                                }
                                break;

                            case 2://Recep and Janitor Stats
                                payroll.JanitorAndReceptionList();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Please enter either \"1\" or \"2\".");
                                    break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please select:\n \"1\" for Doctor to Draw Patient Blood\n" +
                                           "\"2\" for Doctor Patient Care\n" +
                                           "\"3\" for Nurse to Draw Patient Blood\n" +
                                           "\"4\" for Nurse Patient Care\n");
                        int medicalResponse = Convert.ToInt32(Console.ReadLine());
                        switch (medicalResponse)
                        {
                            case 1:
                                payroll.DoctorBloodDraw();
                                Console.WriteLine("Doctor has drawn blood samples and sent them to the lab for testing.");
                                break;
                            case 2:
                                payroll.DoctorCare();
                                Console.WriteLine("Doctor has cared for the patients");
                                break;
                            case 3:
                                payroll.NurseBloodDraw();
                                Console.WriteLine("Nurse has drawn blood sample and sent it to the lab for testing.");
                                break;
                            case 4:
                                payroll.NurseCare();
                                Console.WriteLine("Doctor has cared for the patients");
                                break;
                        }
                        break;
                    case 5://payroll
                        Console.WriteLine("Please select:\n \"1\"Pay All Employees\n" +
                                                            "\"2\" Select Employee for Payment");
                        int payResponse = Convert.ToInt32(Console.ReadLine());
                        switch (payResponse)
                        {
                            case 1:
                                payroll.PayAll();
                                Console.WriteLine("All Employees have been paid");
                                break;
                            case 2:
                                Console.WriteLine("Please Select an Employee for payment:");
                                break;
                            default:
                                Console.WriteLine("Please selece \"1\" for pay all or \"2\" to pay a single employee");
                                break;
                        }

                        int menuResponse6 = Convert.ToInt32(Console.ReadLine());
                        switch (menuResponse6)
                        {
                            case 1://Select who to pay

                                break;
                        }
                        break;
                    case 6:
                        start = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry.\nPlease enter a value between \"1\" and \"5\"\n");
                        break;
                }
            } while (start);
        }

    }

}
