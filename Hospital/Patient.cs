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

        public int idPatient;
        protected Attended attended;


        #endregion

        #region Constructors

        public Patient()
        {
            idPatient = 0;
            attended = Attended.No;


            name = "";
            contact = "";
            birthday = DateTime.Today;
            gender = 0;
        }


        public Patient(Attended attended, string name, string contact, DateTime birthday, Gender gender)
        {
            this.idPatient = GetNextID();
            this.attended = Attended.No;




            base.name = name;
            base.contact = contact;
            base.birthday = birthday;
            base.gender = gender;
            
        }



        #endregion

        #region Properties


        protected Attended GetAttended { get=> attended; set=> attended = value; }

        protected int Id { get=> idPatient; set=> idPatient = value; }

        #endregion

        #region Functions



        protected int GetNextID()
        {
            return ++Id;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4} - {5}", this.idPatient, this.attended, this.name, this.contact, this.birthday, this.gender);
        }



        #endregion

        #region Enums

        public enum Attended
        {
            No,
            Yes
        }

        #endregion
    }
}