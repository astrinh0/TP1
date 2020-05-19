/*
 * 
 * <copyright file = "Person"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>4/24/2020 12:57:45 PM</date>
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
    public class Person
    {
        /// <summary>
        /// Classe pai de pessoas.
        /// </summary>
        #region Member Variables
        
        private string name;
        protected private int numberSNS;
        protected private string contact;
        protected private string address;
        private DateTime birthday;
        private Gender gender;
        protected private Active active;

        #endregion

        #region Constructors
        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Person()
        {
            name = "";
            numberSNS = 0;
            contact = "";
            address = "";
            birthday = DateTime.Today;
            gender = Gender.ND;
            active = Active.No;


        }

        /// <summary>
        /// construtor com parametros
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numberSNS"></param>
        /// <param name="contact"></param>
        /// <param name="adress"></param>
        /// <param name="birthday"></param>
        /// <param name="gender"></param>
        public Person(string name, int numberSNS, string contact, string adress, DateTime birthday, Gender gender)
        {
            this.name = name;
            this.numberSNS = numberSNS;
            this.contact = contact;
            this.address = adress;
            this.birthday = birthday;
            this.gender = gender;
            this.active = Active.Yes;

        }



        #endregion

        #region Properties

        /// <summary>
        /// Propriedades para aceder as variaveis protegidas
        /// </summary>

        public string Name { get => name; set => name = value; }

        public int NumberSNS { get => numberSNS; set => numberSNS = value; }

        public string Contact { get => contact; set => contact = value; }

        public string Address { get => address; set => address = value; }

        public DateTime Birthday { get => birthday  ; set => birthday = value; }

        public Gender GenderP { get => gender; set => gender = value; }

        public Active GetActive  { get => active; set => active = value; } 


        


        #endregion

        #region Functions


        /// <summary>
        /// função para excepção da data
        /// </summary>
        /// <param name="date"></param>
        public void ValidDate (string date)
        {
            try
            {
                DateTime.Parse(date);
            }
            catch (DateExceptions ex)
            {

                Console.WriteLine("ERROR : " + ex.Message);
            }
            
        }


        #endregion

        #region Enums


        /// <summary>
        /// Enumerados de género e se está activo ou não
        /// </summary>
        public enum Gender
        {
            ND,
            M,
            F
        }

        public enum Active
        {
            No,
            Yes
        }

        #endregion
    }
}