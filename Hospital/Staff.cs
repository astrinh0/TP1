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

namespace Hospital
{
    class Staff : Person
    {
        #region Member Variables

        protected int idStaff;
        protected string job;

        #endregion

        #region Constructors

        public Staff()
        {
            idStaff = 0;
            job = "";


            name = "";
            contact = "";
            birthday = "0/0/0000";
            gender = 0;
        }


        public Staff(string job, string name, string contact, string birthday, Gender gender)
        {
            this.idStaff = GetNextID();
            this.job = job;




            base.name = name;
            base.contact = contact;
            base.birthday = birthday;
            base.gender = gender;

        }

        #endregion

        #region Properties

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

        protected int GetNextID()
        {
            return ++Id;
        }


        #endregion

        #region Enums
        #endregion
    }
}