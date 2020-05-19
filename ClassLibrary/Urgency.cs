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
using System.Net.Sockets;
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
        
        private List<Patient> patients = new List<Patient>();
        private List<Staff> staff = new List<Staff>();
        private List<MedicalAppointment> medicalAppointments = new List<MedicalAppointment>();
        private List<Decease> deceases = new List<Decease>();




        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Urgency()
        {

        }
        
        
        public Urgency(Urgency urgency, List<Patient> patients, List<Staff> staff, List<MedicalAppointment> medicalAppointments,List<Decease> deceases)
        {

            this.patients = patients;
            this.staff = staff;
            this.medicalAppointments = medicalAppointments;
            this.deceases = deceases;

        }




        #endregion

        #region Properties

        public List<Patient> Patients { get => patients; set => patients = value; }

        public List<Staff> Staff { get => staff; set => staff = value; }

        public List<MedicalAppointment> MedicalAppointments { get => medicalAppointments; set => medicalAppointments = value; }

        public List<Decease> Deceases { get => deceases; set => deceases = value; }


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
                if (medic != null && medic.IdStaff == idStaff)
                {
                    return medic;
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
        public void PrintAllStaff(List<Staff> listStaff)
        {
            foreach (var staff in listStaff)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9}", staff.IdStaff, staff.Name, staff.Job, 
                                                                    staff.NumberSNS, staff.Work, staff.GenderP, staff.Birthday.ToShortDateString(), 
                                                                    staff.Contact, staff.Address, staff.GetActive);
            }
              
        }

        public void PrintAllPatients(Patient[] patients)
        {
            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i] != null)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", patients[i].idPatient, patients[i].GenderP, patients[i].Birthday.ToShortDateString(), patients[i].Name, patients[i].Contact, patients[i].decease);
                }

            }

        }

    


        



        #endregion

        #region Enums
        #endregion
    }
}