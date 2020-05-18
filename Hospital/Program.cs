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
            Staff medic = new Staff();
            MedicalAppointment medicalAppointment = new MedicalAppointment();

          

            urgency.patients.Add(patient);
            urgency.staff.Add(medic);
            urgency.medicalAppointments.Add(medicalAppointment);




        }
    }
}