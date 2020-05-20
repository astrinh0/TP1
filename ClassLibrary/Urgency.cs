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
using System.Security;
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
        




        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Urgency()
        {

        }
        
        
        public Urgency(List<Patient> patients, List<Staff> staff, List<MedicalAppointment> medicalAppointments)
        {

            this.patients = patients;
            this.staff = staff;
            this.medicalAppointments = medicalAppointments;
           

        }




        #endregion

        #region Properties

        public List<Patient> Patients { get => patients; set => patients = value; }

        public List<Staff> Staff { get => staff; set => staff = value; }

        public List<MedicalAppointment> MedicalAppointments { get => medicalAppointments; set => medicalAppointments = value; }

       


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
                if (patient.FindPatientById(patient, idPatient) != null)
                {
                    return patient.FindPatientById(patient, idPatient);
                }
            }
            return null;
        }

        

        public Staff FindMedicById(Urgency urgency, int idStaff)
        {
            foreach (var medic in urgency.staff)
            {
                if (medic.FindStaffById(medic, idStaff) != null)
                {
                    return medic.FindStaffById(medic, idStaff);
                }
            }
            return null;
        }


        public MedicalAppointment FindMedicalAppointmentByIdinList(Urgency urgency, int idMedicalAppointment)
        {
            foreach (var medicalAppointment in urgency.MedicalAppointments)
            {
                if (medicalAppointment.FindMedicalAppointmentById(medicalAppointment, idMedicalAppointment) != null)
                {
                    return medicalAppointment.FindMedicalAppointmentById(medicalAppointment, idMedicalAppointment);
                }
               
            }
            return null;
        }


       
        



       






       
        public void PrintAllStaff(List<Staff> listStaff)
        {
            foreach (var staff in listStaff)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9}", staff.IdStaff, staff.Name, staff.Job, 
                                                                    staff.NumberSNS, staff.Work, staff.GenderP, staff.Birthday.ToShortDateString(), 
                                                                    staff.Contact, staff.Address, staff.GetActive);
            }
              
        }

        public void PrintAllPatient(List<Patient> patients)
        {
            foreach (var patient in patients)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9} - {10} - {11} - {12}", patient.IdPatient, patient.Name, patient.Entrace.ToShortDateString(), patient.Leave.ToShortDateString(), patient.Screen, patient.GetAttended, patient.Decease,
                                                                    patient.NumberSNS, patient.GenderP, patient.Birthday.ToShortDateString(),
                                                                    patient.Contact, patient.Address, patient.GetActive);
                                                                    
            }

        }

        public void PrintAllStaff(List<MedicalAppointment> medicalAppointments)
        {
            foreach (var medicalAppointment in medicalAppointments)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4}", medicalAppointment.IdMedicalAppointment, medicalAppointment.CodPatient, medicalAppointment.CodStaff, medicalAppointment.TypeOfMedical,
                                                                            medicalAppointment.Date.ToShortDateString());
            }

        }









        #endregion

        #region Enums
        #endregion
    }
}