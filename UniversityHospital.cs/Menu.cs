﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Menu
    {
            Patient patient = new Patient("");
            Payroll payroll = new Payroll();

        public void MainMenu()
        {
            bool start = true;

            Console.WriteLine("Welcome to Univserity Hospitals Database!");

            payroll.AddPatientToList();
            payroll.AddReceptionistToList();
            payroll.AddNurseToList();
            payroll.AddJanitorToList();
            payroll.AddDoctorToList();
            payroll.AddEmployeeToList();


            do
            {
                Console.WriteLine("What would you like to do?\n\n");
                Console.WriteLine(" 1.  Add New Employee");
                Console.WriteLine(" 2.  Fire an Employee");
                Console.WriteLine(" 3.  Supervise Employee");
                Console.WriteLine(" 4.  Payroll");
                Console.WriteLine(" 5.  Master Employee List");
                Console.WriteLine(" 5.  Done");
                int menuResponse = Convert.ToInt32(Console.ReadLine());

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
                                Console.WriteLine("Please select employee's position:" +
                                                    "1. Doctor" +
                                                    "2. Nurse" +
                                                    "3. Receptionist" +
                                                    "4. Janitor");
                                int positionResponse = Convert.ToInt32(Console.ReadLine());
                                switch (positionResponse)
                                {
                                    case 1:
                                            break;
                                }
                                    
                                break;
                        }

                        break;

                    case 3:
                        SuperviseEmployee();
                        break;//Inform Doctor or Nurse of Patient Need
                    case 4://payroll
                        payroll.EmployeeList();
                        Console.WriteLine("Type number of employee you would like to pay \n Example: Type 2 to pay Roth, Elise");

                        int menuResponse6 = Convert.ToInt32(Console.ReadLine());
                        switch (menuResponse6)
                        {
                            case 1://Select who to pay

                                break;
                        }
                        break;
                    case 5:
                        payroll.AddEmployeeToList();
                        payroll.EmployeeMasterList();
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

        public void SuperviseEmployee()
        {
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
                            }
                            break;
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

        }

    }

}
