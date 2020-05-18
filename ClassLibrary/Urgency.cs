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
        public List<Staff> medics = new List<Staff>();
        public List<MedicalAppointment> medicalAppointments = new List<MedicalAppointment>();



        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Urgency()
        {
            this.patients = new List<Patient>();
            this.medics = new List<Staff>();
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
            urgency.medics.Add(medic);
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

        /*public Syntomns FindSyntomnById(Urgency urgency, int idSyntomn)
        {
            foreach (var syntomn in urgency.syntomns)
            {
                if (syntomn != null && syntomn.idSyntomns == idSyntomn)
                {
                    return syntomn;
                }
            }
            return null;
        }*/

        public Staff FindMedicById(Urgency urgency, int idStaff)
        {
            foreach (var medic in urgency.medics)
            {
                if (medic != null && medic.idStaff == idStaff)
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
        internal Patient AddPatientToUrgency(List<Urgency> urgency, Patient patient)
        {
            

            return null;
        }


        internal Staff AddMedictToUrgency(Urgency urgency, Staff medic)
        {
            

            return null;
        }

       /* internal Syntomns AddSyntomnsToUrgency(Urgency urgency, Syntomns syntomn)
        {
            for (int i = 0; i < urgency.syntomns.Length; i++)
            {
                if (urgency.syntomns[i] == null)
                {
                    urgency.syntomns[i] = syntomn;
                    return urgency.syntomns[i];
                }
            }

            return null;
        }*/


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