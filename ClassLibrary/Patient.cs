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
using System.Security.Cryptography;
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
        private string disease;
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
            disease = "";
            screening = Screening.ND;
            entrance = DateTime.Today;


            Name = "";
            contact = "";
            Birthday = DateTime.Today;
            GenderP = Gender.ND;
            active = Active.No;
          
        }

        
       
        public Patient( string name, string contact, DateTime birthday, Gender gender, string address, int numberSNS, DateTime entrance)
        {
            this.idPatient = Interlocked.Increment(ref globalID);
            this.attended = Attended.No;
            this.disease = "";
            this.screening = Screening.ND;
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

        

        public int IdPatient { get => idPatient; set => this.idPatient = value; }


        public Attended GetAttended { get => attended; set => attended = value; }

        public string Disease { get => disease; set => disease = value; }

        public Screening Screen { get => screening; set => screening = value; }

        public DateTime Entrace { get => entrance; set => entrance = value; }

        public DateTime Leave { get => leave; set => leave = value; }

        public int GlobalID { get => globalID; set => globalID = value; }

        #endregion

        #region Functions

        public Patient CreateNewPatient(Patient patient)
        {
            this.idPatient = Interlocked.Increment(ref globalID);
            Console.WriteLine("Diga o nome:\n");
            patient.Name = Console.ReadLine();
            Console.WriteLine("Diga o contacto:\n");
            patient.Contact = Console.ReadLine();
            Console.WriteLine("Diga a morada:\n");
            patient.Address = Console.ReadLine();
            Console.WriteLine("Diga a sua data de nascimento:\n");
            patient.Birthday = DateTime.TryParse(Console.ReadLine(), out DateTime aux) ? aux : DateTime.Today;
            Console.WriteLine("Diga o number de utente:\n");
            patient.NumberSNS = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Diga o sexo:\n");
            patient.GenderP = (Patient.Gender)Enum.Parse(typeof(Patient.Gender), Console.ReadLine());
            Console.WriteLine("Data de entrada:\n");
            patient.Entrace = DateTime.TryParse(Console.ReadLine(), out DateTime auxEntrance) ? auxEntrance : DateTime.Today;
            patient.GetActive = Person.Active.Yes;

            return patient;

        }


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
                patient.leave = DateTime.Today;
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