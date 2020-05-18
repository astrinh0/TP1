/*
 * 
 * <copyright file = "Urgency"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>4/25/2020 3:06:45 PM</date>
 * <description></description>
 * 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBarcelos
{
    /// <summary>
    /// Classe que organiza todas as classes, 
    /// defini esta classe para definir os arrays que precisava e que estao ligados
    /// </summary>
    public class Urgency
    {
        #region Member Variables
        public List<Patient> patients;
        public List<Staff> staff = new List<Staff>();
        public List<MedicalAppointment> medicalAppointments = new List<MedicalAppointment>();



        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Urgency()
        {
            this.patients = new List<Patient>();
            this.staff = new List<Staff>();
            this.medicalAppointments = new List<MedicalAppointment>();

        }
        /// <summary>
        /// Construtor por parametros
        /// </summary>
        /// <param name="urgency"></param>
        /// <param name="patient"></param>
        /// <param name="medic"></param>
        /// <param name="medicalAppointment"></param>
        
        public Urgency(Urgency urgency, Patient patient, Staff medic, MedicalAppointment medicalAppointment)
        {
            urgency.patients.Add(patient);
            urgency.staff.Add(medic);
            urgency.medicalAppointments.Add(medicalAppointment);


        }

        


        #endregion

        #region Properties
        #endregion

        #region Functions


        /// <summary>
        /// Funcoes de Procura e que devolve o que procura caso encontre, caso contrario devolve null
        /// </summary>
        /// <param name="urgency"></param>
        /// <param name="idPatient"></param>
        /// <returns></returns>
        public Patient FindPatientById(Urgency urgency, int idPatient)
        {
            foreach (var patient in urgency.patients)
            {
                if (patient != null && patient.idPatient == idPatient)
                {
                    return patient;
                }
            }
            return null;
        }

        

        public Staff FindMedicById(Urgency urgency, int idStaff)
        {
            foreach (var medic in urgency.staff)
            {
                if (medic != null && medic.idStaff == idStaff)
                {
                    return medic;
                }
            }
            return null;
        }

        public MedicalAppointment FindMedicalAppointmentById(Urgency urgency, int idMedicalAppointment)
        {
            foreach (var medicalAppointment in urgency.medicalAppointments)
            {
                if (medicalAppointment != null && medicalAppointment.idMedicalAppointment == idMedicalAppointment)
                {
                    return medicalAppointment;
                }
            }
            return null;
        }




        /// <summary>
        /// Adiciona no array respectivo, caso nao consiga devolve null.
        /// </summary>
        /// <param name="urgency"></param>
        /// <param name="patient"></param>
        /// <returns></returns>
        

       


        /// <summary>
        /// Imprime o array respectivo!
        /// </summary>
        /// <param name="medics"></param>
        public void PrintAllMedics(Staff[] medics)
        {
            for (int i = 0; i < medics.Length; i++)
            {
                if (medics[i] != null)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4}", medics[i].idStaff, medics[i].birthday, medics[i].gender, medics[i].Name, medics[i].Contact);
                }

            }

        }

        public void PrintAllPatients(Patient[] patients)
        {
            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i] != null)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", patients[i].idPatient, patients[i].gender, patients[i].birthday, patients[i].Name, patients[i].Contact, patients[i].decease);
                }

            }

        }

    


        



        #endregion

        #region Enums
        #endregion
    }
}