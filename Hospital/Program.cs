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

namespace Hospital
{
    class Program
    {
        static void Main()
        {
            /// Zona de testes

            Urgency u = new Urgency();
            MedicalAppointment[] consultas = new MedicalAppointment[100];
            

            Patient patient = new Patient(Patient.Attended.No, "Fernando", "213123123", new DateTime(1990, 02, 13), Person.Gender.M, 1);
            u.AddPatientToUrgency(u, patient);

            

            Staff medic = new Staff("Oncologist", "Paul", "919211233", new DateTime(1993, 02, 23), Person.Gender.M);
            u.AddMedictToUrgency(u, medic);
            
            Syntomns syntomn = new Syntomns("Cancer", Syntomns.Screening.E, u.medics[0].idStaff);
            u.AddSyntomnsToUrgency(u, syntomn);

            consultas[0] = new MedicalAppointment("Consulta de rotina", u.medics[0].idStaff, u.patients[0].idPatient);

            u.PrintAllMedics(u.medics);
            Console.ReadKey();
            u.PrintAllPatients(u.patients);
            Console.ReadKey();
            u.PrintAllSyntomns(u.syntomns);
            Console.ReadKey();



            Console.ReadKey();


           
        }
    }
}