using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Menu
    {
        bool start = true;
        Payroll payroll = new Payroll();
        Doctor doctor;
        Patient patient;
       




        public void MainMenu()
        {
            Console.WriteLine("Welcome to Univserity Hospitals Database!");

            do
            {
                Console.WriteLine("What would you like to do?\n\n");
                Console.WriteLine(" 1.  Add New Employee");
                Console.WriteLine(" 2.  Fire an Employee");
                Console.WriteLine(" 3.  Supervise Employee");
                Console.WriteLine(" 4.  Payroll");
                Console.WriteLine(" 5.  Done");
                int menuResponse = Convert.ToInt32(Console.ReadLine());


                //int menuResponse3 = Convert.ToInt32(Console.ReadLine());

                // STILL WORKING ON THIS, NEEDED TO REARRANGE SOME THINGS TO HAVE LIST MAKE SENSE. 

                payroll = new Payroll(); //I think this is where we need to reference it to get the add list method to work, but I'm still having trouble getting it to run


                if (menuResponse.Equals(6))
                {   
                    start = false;
                }

                switch (menuResponse)
                {
                    case 1:
                        break;
                    case 2:
                        payroll.EmployeeList();
                        payroll.FireDoctor(doctor);
                        doctor = doctor.ChooseEmployee(payroll);

                        break;
                       
                    case 3://Inform Doctor or Nurse of Patient Need
                                Console.WriteLine("1. Inform Doctor or Nurse of Patient Need\n" +
                                                     "2. Review Receptionists and Janitors' Status'" );
                                
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
                                    case 1:
                                    payroll.PatientList();              
                                    Console.WriteLine("Which patient should be assisted?");
                                        //Create index to select from Doctor and Nurse List

                                        int menuResponse4 = Convert.ToInt32(Console.ReadLine());
                                        switch (menuResponse4)
                                        {
                                            case 1:
                                                break;
                                        }
                                        break;
              
                                }
                                //payroll.AddNurseToList();

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
                
                    case 4:
                        payroll.EmployeeList();
                        Console.WriteLine("To pay an employee type 1");

                        int menuResponse5 = Convert.ToInt32(Console.ReadLine());
                        switch (menuResponse5)
                        {
                            case 1:
                                break;
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Please enter a value between \"1\" and \"6\"");
                        break;
                }
            } while (start);
        }

    }
        
}
