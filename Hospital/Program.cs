/*
 * 
 * <copyright file = "$safeitemrootname$"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>$time$</date>
 * <description></description>
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalBarcelos;

namespace Hospital
{
    public class Program
    {

       
        static void Main()
        {
            /// Zona de testes

            Urgency urgency = new Urgency();
            Patient patient = new Patient();
            Staff medic = new Staff();
            MedicalAppointment medicalAppointment = new MedicalAppointment();
            urgency.LoadPatientsFromFile();


            Console.WriteLine("Listagem de Staff");
            Console.WriteLine();
            urgency.PrintAllStaff(urgency.Staff);
            Console.WriteLine();

            Console.WriteLine("Listagem de Pacientes");
            Console.WriteLine();
            urgency.PrintAllPatients(urgency.Patients);
            Console.WriteLine();

            Console.WriteLine("Listagem de Consultas Existentes");
            Console.WriteLine();
            urgency.PrintAllMedicalAppointments(urgency.MedicalAppointments);




            //patient = patient.CreateNewPatient(patient);
            //urgency.Patients.Add(patient);

            //medic = medic.CreateNewStaff(medic);
            //urgency.Staff.Add(medic);

            

            medicalAppointment = medicalAppointment.CreateNewMedicalAppointment(medicalAppointment, patient, medic);
            urgency.MedicalAppointments.Add(medicalAppointment);


            

            urgency.AddDiseaseToPatient(urgency.Patients, 1);
            urgency.Patients.Sort((x, y) => -x.Screen.CompareTo(y.Screen));
            medicalAppointment = medicalAppointment.CreateNewMedicalAppointment(medicalAppointment, urgency.Patients.First(), urgency.Staff.First());
            urgency.MedicalAppointments.Add(medicalAppointment);
            urgency.Patients.Sort((x, y) => -x.Screen.CompareTo(y.Screen));


            




            urgency.PrintPatient(urgency.FindPatientByIdinList(urgency, 1));





           







            //Staff medic = new Staff("medico", "Joao", "1254454", new DateTime(1993, 02, 28), Person.Gender.M, Staff.Working.Y, "Rua do Caralho", 88498449) ;
            //Staff nurse = new Staff("enfermeira", "Emily Ratokvski", "4498498", new DateTime(1990, 02, 28), Person.Gender.F, Staff.Working.Y, "Rua do Caralho", 98494949);
            //MedicalAppointment medicalAppointment = new MedicalAppointment("consulta de cancro", 1, 2, new DateTime(1990, 02, 28));
            //Staff medic = new Staff("medico", "Joao", "1254454", new DateTime(1993, 02, 28), Person.Gender.M, Staff.Working.Y, "Rua do Caralho", 88498449) ;
            //Staff nurse = new Staff("enfermeira", "Emily Ratokvski", "4498498", new DateTime(1990, 02, 28), Person.Gender.F, Staff.Working.Y, "Rua do Caralho", 98494949);
            //MedicalAppointment medicalAppointment = new MedicalAppointment("consulta de cancro", 1, 2, new DateTime(1990, 02, 28));




            //urgency.Staff.Add(medic);
            //urgency.Staff.Add(nurse);
            //urgency.MedicalAppointments.Add(medicalAppointment);




            urgency.SavePatientsToFile();

            Console.ReadKey();



        }

        
    }
}