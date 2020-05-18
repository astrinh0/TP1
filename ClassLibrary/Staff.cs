/*
 * 
 * <copyright file = "Staff"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>4/24/2020 1:39:22 PM</date>
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
    /// Classe de Staff que herda de Pessoa.
    /// </summary>
    public class Staff : Person
    {
        #region Member Variables

        public int idStaff;
        public string job;
        public Working working; 




        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Staff()
        {
            idStaff = 0;
            job = "";


            name = "";
            contact = "";
            birthday = DateTime.Today;
            gender = 0;
            working = Working.N;
        }

        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="job"></param>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="birthday"></param>
        /// <param name="gender"></param>
        public Staff(string job, string name, string contact, DateTime birthday, Gender gender, Working working)
        {
            this.idStaff = GetNextID();
            this.job = job;
            this.working = working;
 



            base.name = name;
            base.contact = contact;
            base.birthday = birthday;
            base.gender = gender;

        }



        #endregion

        #region Properties

        /// <summary>
        /// Propriedades para aceder as variaveis protegidas
        /// </summary>
        protected int Id
        {
            get
            {
                return idStaff;
            }
            set
            {
                this.idStaff = value;
            }

        }

        protected string Job
        {
            get
            {
                return job;
            }
            set
            {
                this.job = value;
            }

        }


        #endregion

        #region Functions

        /// <summary>
        /// funcao que gera automaticamente o ID
        /// </summary>
        /// <returns></returns>
        protected int GetNextID()
        {
            return ++Id;
        }


        #endregion

        #region Enums

        public enum Working
        {
            N,
            Y
        }
        #endregion
    }
}