/*
 * 
 * <copyright file = "Patient"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>4/24/2020 2:00:17 PM</date>
 * <description></description>
 * 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HospitalBarcelos
{
    /// <summary>
    /// Classe de Paciente que herda de Pessoa
    /// </summary>
    public class Patient : Person
    {
        #region Member Variables

        private int idPatient;
        private protected Attended attended;
        private string decease;
        private Screening screening;
        private DateTime entrance;
        private DateTime leave;

        private static int globalID;

        


        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Patient()
        {
            idPatient = 0;
            attended = Attended.No;
            decease = "";
            screening = Screening.ND;
            entrance = DateTime.Today;


            Name = "";
            contact = "";
            Birthday = DateTime.Today;
            GenderP = Gender.ND;
            active = Active.No;
          
        }

        
       
        public Patient(Attended attended, string name, string contact, DateTime birthday, Gender gender, string decease, Screening screening, string address, int numberSNS, DateTime entrance)
        {
            this.idPatient = Interlocked.Increment(ref globalID);
            this.attended = attended;
            this.decease = decease;
            this.screening = screening;
            this.entrance = entrance;




            base.Name = name;
            base.Contact = contact;
            base.Birthday = birthday;
            base.GenderP = gender;
            base.Address = address;
            base.NumberSNS = numberSNS;
            base.active = Active.Yes;

        }



        #endregion

        #region Properties
        /// <summary>
        /// Propriedades para aceder as variaveis protegidas
        /// </summary>

        

        public int IdPatient { get => idPatient; set => idPatient = value; }


        public Attended GetAttended { get => attended; set => attended = value; }

        public string Decease { get => decease; set => decease = value; }

        public Screening Screen { get => screening; set => screening = value; }

        public DateTime Entrace { get => entrance; set => entrance = value; }

        public DateTime Leave { get => leave; set => leave = value; }

        #endregion

        #region Functions

        public Patient FindPatientById(Patient patient, int idPatient)
        {
            if (patient != null && patient.IdPatient == idPatient)
            {
                return patient;
            }
            return null;
        }

        public Patient FindPatientByName(Patient patient, string name)
        {
            if (patient != null && patient.Name == name)
            {
                return patient;
            }
            return null;
        }

        public Patient ShowActivePatient(Patient patient)
        {
            if (patient != null && patient.active == Active.Yes)
            {
                return patient;
            }
            return null;
        }

        
        public bool AddDeceaseToPatient(Patient patient, string decease, Screening screening, int idPatient)
        {
            var today = DateTime.Today;

            if (patient != null && patient.idPatient == idPatient)
            {
                patient.decease = decease;
                var aux = today.Year - patient.Birthday.Year;
                if (aux > 50 && screening != Screening.R)
                {
                    patient.screening = screening+1;
                }
                else
                {
                    patient.screening = screening;
                }
                return true;
            }

            return false;
        }

        public bool ChangeAddress(Patient patient, string address, int idPatient)
        {
            if (patient != null && patient.idPatient == idPatient)
            {
                patient.address = address;
                return true;
            }

            return false;
        }

        public bool LeavingHospital(Patient patient, int idPatient, DateTime date)
        {
            if (patient != null && patient.idPatient == idPatient)
            {
                patient.leave = date;
                patient.active = Active.No;
                return true;

            }
            return false;
        }


        public bool RemovePatient(Patient patient, int idPatient)
        {
            if (patient != null && patient.idPatient == idPatient)
            {
                patient.active = Active.No;
                return true;
            }

            return false;
        }

        

        #endregion

        #region Enums



        /// <summary>
        /// Enumerado para ver se foi atendido ou nao
        /// </summary>
        public enum Attended
        {
            No,
            Yes
        }

        public enum Screening
        {
            ND,
            G,
            Y,
            O,
            R
        }

        #endregion
    }
}