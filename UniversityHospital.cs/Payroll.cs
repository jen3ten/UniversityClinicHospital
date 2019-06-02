using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Payroll
    {
        public List<Doctor> doctorList = new List<Doctor>();
        public List<Nurse> nurseList = new List<Nurse>();
        public List<Janitor> janitorList = new List<Janitor>();
        public List<Receptionist> receptionistList = new List<Receptionist>();
        public List<Patient> patientList = new List<Patient>();

        Doctor dr1 = new Doctor("Francona, Terry", 8561, "Gastroenterology", "N/A");
        Doctor dr2 = new Doctor("Roth, Elise\t", 8213, "Neuro Surgeon", "N/A");
        Doctor dr3 = new Doctor("Dolson, Miranda", 8497, "Obstetrics\t", "N/A");
        Doctor dr4 = new Doctor("Sandhu, Cory\t", 8109, "Pediatrics\t", "N/A");
        Doctor dr5 = new Doctor("Messaros, Kyle", 8670, "Oncology\t", "N/A"); 
        /// Number of patient were in the requirements for Nurses only
        Nurse n1 = new Nurse("Marshall, Ruby", 7512, "--", "21");
        Nurse n2 = new Nurse("Basiba, John\t", 7734, "--", "11");
        Nurse n3 = new Nurse("Kacy, Michael", 7298, "--", "9");
        Nurse n4 = new Nurse("Maxwell, Linda", 7181, "--", "14");
        Nurse n5 = new Nurse("Johns, Nicole", 7604, "--", "8");
        Nurse n6 = new Nurse("Medina, Cindy", 7155, "--", "17");
        Nurse n7 = new Nurse("Listner, Casey", 7640, "--", "23");
        Nurse n8 = new Nurse("Masina, Ben\t", 7005, "--", "7");
        Nurse n9 = new Nurse("Richards, Mason", 7371, "--", "20");
        Nurse n10 = new Nurse("Smith, Jessica", 7492, "--", "13");

        Janitor j1 = new Janitor("Smith, Matthew", 3561, "Yes");
        Janitor j2 = new Janitor("Watt, Jonathan", 3213, "No ");
        Janitor j3 = new Janitor("Muller, Walter", 3629, "No ");
        Janitor j4 = new Janitor("Madison, Jim", 3462, "Yes");
        Janitor j5 = new Janitor("Harrison, Lloyd", 3901, "Yes");
        Janitor j6 = new Janitor("Adams, Scott", 3764, "No ");

        Receptionist r1 = new Receptionist("Balou, Mary\t", 1058, "No ", "N/A");
        Receptionist r2 = new Receptionist("Lazara, Kim\t", 1058, "Yes", "N/A");

        Patient p1 = new Patient("Stone, Travis", 10874);
        Patient p2 = new Patient("Jones, Angel", 15823);
        Patient p3 = new Patient("Hamilton, Thomas", 12561);
        Patient p4 = new Patient("Kipnis, Jason", 16810);
        Patient p5 = new Patient("Kluber, Bridget", 10894);

        public void AddDoctorToList()
        {
            doctorList.Add(dr1);
            doctorList.Add(dr2);
            doctorList.Add(dr3);
            doctorList.Add(dr4);
            doctorList.Add(dr5);
        }

        public void AddNurseToList()
        {
            nurseList.Add(n1);
            nurseList.Add(n2);
            nurseList.Add(n3);
            nurseList.Add(n4);
            nurseList.Add(n5);
            nurseList.Add(n6);
            nurseList.Add(n7);
            nurseList.Add(n8);
            nurseList.Add(n9);
            nurseList.Add(n10);
        }

        public void AddJanitorToList()
        {
            janitorList.Add(j1);
            janitorList.Add(j2);
            janitorList.Add(j3);
            janitorList.Add(j4);
            janitorList.Add(j5);
            janitorList.Add(j6);
        }

        public void AddReceptionistToList()
        {
            receptionistList.Add(r1);
            receptionistList.Add(r2);
        }

        public void AddPatientToList()
        {
            patientList.Add(p1);
            patientList.Add(p2);
            patientList.Add(p3);
            patientList.Add(p4);
            patientList.Add(p5);
        }


        public void EmployeeList()
        {
            Console.WriteLine("\n\t-----Employee List:-----");
            Console.WriteLine("Employee Name\t\t| Position\t|  Number |  Salary\t|  Paid     |");
            Console.WriteLine("------------------------|---------------|---------|-------------|-----------|");

            AddDoctorToList();
            AddNurseToList();
            AddJanitorToList();
            AddReceptionistToList();

            int i = 1;
            foreach (Doctor element in doctorList)
            {
                Console.WriteLine($"{i++}. {element.Name}\t| {element.Position}\t|  {element.EmployeeNumber}   | {element.Salary}\t|   {element.Payment}   |");
            }
            foreach(Nurse element in nurseList)
            {
                Console.WriteLine($"{i++}. {element.Name}\t| {element.Position}\t\t|  {element.EmployeeNumber}   | {element.Salary}\t|   {element.Payment}   |");
            }
            foreach(Janitor element in janitorList)
            {
                Console.WriteLine($"{i++}. {element.Name}\t| {element.Position}\t|  {element.EmployeeNumber}   | {element.Salary}\t|   {element.Payment}   |");
            }
            foreach(Receptionist element in receptionistList)
            {
                Console.WriteLine($"{i++}. {element.Name}\t| {element.Position}\t|  {element.EmployeeNumber}   | {element.Salary}\t|   {element.Payment}   |");
            }
            Console.WriteLine(" ");
        }

        public void DoctorAndNurseList()
        {

            Console.WriteLine("\n----Employee -- Patient Interaction -- List:");
            Console.WriteLine("Employee Name\t\t| Number | Specialty\t\t| # of Patients |");
            Console.WriteLine("------------------------|--------|----------------------|---------------|");

            AddDoctorToList();
            AddNurseToList();

            int i = 1;
            foreach (Doctor element in doctorList)
            {
                Console.WriteLine($"{i++}. {element.Name}\t|  {element.EmployeeNumber}  | {element.SpecialtyArea}\t| \t{element.NumberOfPatients} \t|");
            }
            foreach(Nurse element in nurseList)
            {
                Console.WriteLine($"{i++}. {element.Name}\t|  {element.EmployeeNumber}  |\t--\t{element.SpecialtyArea}\t| \t{element.NumberOfPatients} \t|");

            }
            Console.WriteLine(" ");
        }

        public void JanitorAndReceptionList()
        {

            Console.WriteLine("\n----Employee-- Non Patient Interaction-- List:");
            Console.WriteLine("Employee Name\t\t| Number |  Sweeping  |  On Phone   |");
            Console.WriteLine("------------------------|--------|------------|-------------|");

            AddReceptionistToList();
            AddJanitorToList();

            int i = 1;
            foreach (Janitor element in janitorList)
            {
                Console.WriteLine($"{i++}. {element.Name} \t|  {element.EmployeeNumber}  |     {element.Sweep}    |    --       |");
            }
            foreach(Receptionist element in receptionistList)
            {
                Console.WriteLine($"{i++}. {element.Name}\t|  {element.EmployeeNumber}  | \t--    |    {element.OnPhone}      |");
            }
            Console.WriteLine(" ");
        }

        public void PatientList()
        {

            // Console.WriteLine("\n----Employee-- Non Patient Interaction-- List:");
            Console.WriteLine("Patient Name\t\t| Patient Number |  Health Level |  Blood Level   |");
            Console.WriteLine("-------------------|--------|------------|-------------|");

            AddPatientToList();

            int i = 1;
            foreach (Patient element in patientList)
            {
                Console.WriteLine($"{i++}. {element.Name} \t|  {element.PatientNumber}  |     {element.HealthLevel}    |    {element.BloodLevel}       |");
            }

            Console.WriteLine(" ");
        }


        public void FireDoctor(Doctor doctor)
        {
            doctorList.Remove(doctor);
        }

        public void FireNurse(Nurse nurse)
        {
            nurseList.Remove(nurse);
        }
        public void FireReceptionist(Receptionist receptionist)
        {
            receptionistList.Remove(receptionist);
        }
        public void FireJanitor(Janitor janitor)
        {
            janitorList.Remove(janitor);
        }
    }
}
