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

        protected int id;
        protected int countSyntomns;
        protected int syntomns;
        protected bool attended;
        protected Screening screening;


        #endregion

        #region Constructors

        public Patient()
        {
            id = 0;
            countSyntomns = 0;
            attended = false;


            name = "";
            contact = "";
            birthday = "0/0/0000";
            gender = 0;
            screening = 0;
        }


        public Patient(int id, int countSyntomns, bool attended, string name, string contact, string birthday, Gender gender, Screening screening)
        {
            this.id = GetNextID();
            this.countSyntomns = countSyntomns;
            this.attended = attended;




            this.name = name;
            this.contact = contact;
            this.birthday = birthday;
            this.gender = gender;
            this.screening = screening;
        }



        #endregion

        #region Properties

        protected int CountSyntomns { get=> countSyntomns; set => countSyntomns = value; }

        protected bool Attended { get=> attended; set=> attended = value; }

        protected int Id { get=> id; set=> id = value; }


        #endregion

        #region Functions


        protected int GetNextID()
        {
            return ++Id;
        }


        #endregion

        #region Enums

        public enum Screening
        {
            NU,
            LU,
            U,
            VU,
            E
        }

        #endregion
    }
}