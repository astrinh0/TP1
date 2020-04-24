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
        #region Member Variables

        protected string name;
        protected string contact;
        public string birthday;
        public Gender gender;

        #endregion

        #region Constructors

        public Person()
        {
            name = "";
            contact = "";
            birthday = "0/0/0000";
            gender = 0;

        }


        public Person(string name, string contact, string birthday, Gender gender)
        {
            this.name = name;
            this.contact = contact;
            this.birthday = birthday;
            this.gender = gender;

        }



        #endregion

        #region Properties
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
        public enum Gender
        {
            ND,
            M,
            F
        }

        #endregion
    }
}