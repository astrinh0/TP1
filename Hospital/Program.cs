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

            Staff medic = new Staff("Oncologist",
                                    "Paul",
                                    "919211233",
                                    new DateTime(1993, 02, 23),
                                    Person.Gender.M);
            Console.WriteLine(medic.ToString());

            Patient paciente = new Patient(Patient.Attended.No, "Fernando", "213123123", new DateTime(1990, 02, 13), Person.Gender.M);
            Console.WriteLine(paciente.ToString());
            

            Syntomns syntomns = new Syntomns("Cancer", Syntomns.Screening.E, medic.idStaff);
            Console.WriteLine(syntomns.ToString());
            syntomns.AddCodPatient(syntomns, paciente.idPatient);
            syntomns.PrintArray(syntomns.codPatient);
            Console.ReadKey();


            MedicalAppointment consulta = new MedicalAppointment("Consulta de Oncologia", medic.idStaff, paciente.idPatient);


           
        }
    }
}