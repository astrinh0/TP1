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
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Patient : Person
    {
        #region Member Variables

        protected int idPatient;
        protected bool attended;


        #endregion

        #region Constructors

        public Patient()
        {
            idPatient = 0;
            attended = false;


            name = "";
            contact = "";
            birthday = "0/0/0000";
            gender = 0;
        }


        public Patient(bool attended, string name, string contact, string birthday, Gender gender)
        {
            this.idPatient = GetNextID();
            this.attended = attended;




            base.name = name;
            base.contact = contact;
            base.birthday = birthday;
            base.gender = gender;
            
        }



        #endregion

        #region Properties


        protected bool Attended { get=> attended; set=> attended = value; }

        protected int Id { get=> idPatient; set=> idPatient = value; }

        #endregion

        #region Functions


        protected int GetNextID()
        {
            return ++Id;
        }


        #endregion

        #region Enums

        #endregion
    }
}