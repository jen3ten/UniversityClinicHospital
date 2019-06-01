using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Doctor : Employee

    {

        public string SpecialtyArea { get; set; }

        public Doctor(string name, int number, string specialty, string patientNumber) : base()
        {
            Position = "Doctor";
            Salary = "$90,000";
            SpecialtyArea = specialty;
            Name = name;
            EmployeeNumber = number;
            NumberOfPatients = patientNumber;
            //SalaryPaid = false;
        }

        /*Payroll payroll = new Payroll();

        public Doctor(string name) : base()  // having trouble w argument- following ex in practice inheritance we did in class... After we get this part everything else should fall through
        {
            name = "Francona, Terry";
            name = "Roth, Elise";    //??
                                                       //Salary is being inherited - why I took salary out
        }


                                                        // I believe this should 

            //Doctor dr1 = new Doctor("Francona, Terry", 8561, "");
            //Doctor dr2 = new Doctor("Roth, Elise", 8213, "");
            //Doctor dr3 = new Doctor("Dolson, Miranda", 8497, "");
            //Doctor dr4 = new Doctor("Sandhu, Cory", 8109, "");
            //Doctor dr5 = new Doctor("Messaros, Kyle", 8670, "");
    }*/
    }
}
