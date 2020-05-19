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
    class Program
    {
        static void Main()
        {
            /// Zona de testes

            Urgency urgency = new Urgency();
            Patient patient = new Patient();
            Staff medic = new Staff("medico", "Joao", "1254454", new DateTime(1993, 02, 28), Person.Gender.M, Staff.Working.Y, "Rua do Caralho", 88498449) ;
            Staff nurse = new Staff("enfermeira", "Emily Ratokvski", "4498498", new DateTime(1990, 02, 28), Person.Gender.F, Staff.Working.Y, "Rua do Caralho", 98494949);
            MedicalAppointment medicalAppointment = new MedicalAppointment("consulta de cancro", 1, 2);
            Decease decease = new Decease(Patient.Screening.R, "COVID");
          

            urgency.Patients.Add(patient);
            urgency.Staff.Add(medic);
            urgency.Staff.Add(nurse);
            urgency.MedicalAppointments.Add(medicalAppointment);
            urgency.Deceases.Add(decease);
            urgency.PrintAllStaff(urgency.Staff);
            Console.ReadKey();



        }
    }
}