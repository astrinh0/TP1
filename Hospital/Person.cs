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

namespace Hospital
{
    class Person
    {
        /// <summary>
        /// Classe pai de pessoas.
        /// </summary>
        #region Member Variables

        protected string name;
        protected string contact;
        public DateTime birthday;
        public Gender gender;

        #endregion

        #region Constructors
        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Person()
        {
            name = "";
            contact = "";
            birthday = DateTime.Today;
            gender = 0;

        }

        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="birthday"></param>
        /// <param name="gender"></param>
        public Person(string name, string contact, DateTime birthday, Gender gender)
        {
            this.name = name;
            this.contact = contact;
            this.birthday = birthday;
            this.gender = gender;

        }



        #endregion

        #region Properties

        /// <summary>
        /// Propriedades para aceder as variaveis protegidas
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }



        public string Contact
        {
            get
            {
                return contact;
            }
            set
            {
                this.contact = value;
            }
        }

        #endregion

        #region Functions

        #endregion

        #region Enums


        /// <summary>
        /// Enumerado para o sexo de pessoa
        /// </summary>
        public enum Gender
        {
            ND,
            M,
            F
        }

        #endregion
    }
}