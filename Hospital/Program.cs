﻿/*
 * 
 * <copyright file = "$safeitemrootname$"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>$time$</date>
 * <description></description>
 * 
 */


using HospitalBarcelos;
using System;
using System.Linq;

namespace Hospital
{
    public class Program
    {
       
        static void Main()
        {
            

            Urgency urgency = new Urgency();
            Patient patient = new Patient();
            Staff medic = new Staff();
            MedicalAppointment medicalAppointment = new MedicalAppointment();

            
           
            urgency.LoadPatientsFromFile();
            urgency.LoadMedicalAppointmentFromFile();
            urgency.LoadStaffFromFile();


            Console.WriteLine("Listagem de Staff");
            Console.WriteLine();
            Console.WriteLine("Quantidade: {0}", urgency.Patients.Count);
            urgency.PrintAllStaff(urgency.Staff);
            Console.WriteLine();

            Console.WriteLine("Listagem de Pacientes");
            Console.WriteLine();
            Console.WriteLine("Quantidade: {0}", urgency.Staff.Count);
            urgency.PrintAllPatients(urgency.Patients);
            Console.WriteLine();

            Console.WriteLine("Listagem de Consultas Existentes");
            Console.WriteLine();
            Console.WriteLine("Quantidade: {0}", urgency.MedicalAppointments.Count);
            urgency.PrintAllMedicalAppointments(urgency.MedicalAppointments);
            Console.WriteLine("Premir qualquer tecla para continuar");


            Console.ReadKey();

            Console.Clear();
            patient = patient.CreateNewPatient(patient);
            urgency.Patients.Add(patient);

            Console.WriteLine("Premir qualquer tecla para continuar");

            Console.ReadKey();

            Console.Clear();


            


            medic = medic.CreateNewStaff(medic);
            urgency.Staff.Add(medic);

            Console.WriteLine("Premir qualquer tecla para continuar");

            Console.ReadKey();

            Console.Clear();

            





            urgency.AddDiseaseToPatient(urgency.Patients, 1);
            urgency.Patients.Sort((x, y) => -x.Screen.CompareTo(y.Screen));
            medicalAppointment = medicalAppointment.CreateNewMedicalAppointment(medicalAppointment, urgency.Patients.First(), urgency.Staff.First());
            urgency.MedicalAppointments.Add(medicalAppointment);
            urgency.Patients.Sort((x, y) => -x.Screen.CompareTo(y.Screen));



            Console.WriteLine("Premir qualquer tecla para continuar");

            Console.ReadKey();

            Console.Clear();

            



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
            urgency.SaveStaffToFile();
            urgency.SaveMedicalAppointmentsToFile();

            Console.WriteLine("Premir qualquer tecla para fechar");


            Console.ReadKey();

            Environment.Exit(1);



        }

        
    }
}