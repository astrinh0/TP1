/*
 * 
 * <copyright file = "Decease"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>5/19/2020 4:56:19 PM</date>
 * <description></description>
 * 
 */




using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalBarcelos
{
    public class Decease
    {
        #region Member Variables

        protected private int idDecease;
        private Patient.Screening screening;
        private string description;

        #endregion

        #region Constructors
        
        public Decease()
        {
            idDecease = 0;
            screening = Patient.Screening.ND;
            description = "";
        }

        public Decease(Patient.Screening screening, string description)
        {
            this.idDecease = GetNextID();
            this.screening = screening;
            this.description = description;
        }

        #endregion

        #region Properties

        public int IdDecease { get => idDecease; set => idDecease = value; }

        public Patient.Screening Screening { get => screening; set => screening = value; }

        public string Description { get => description; set => description = value; }

        #endregion

        #region Functions

        public int GetNextID()
        {
            return ++this.idDecease;
        }

        public Decease FindDeceaseById(Urgency urgency, int idDecease)
        {
            foreach (var decease in urgency.Deceases)
            {
                if (decease != null && decease.idDecease == idDecease)
                {
                    return decease;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return $"{this.idDecease} - {this.description} - {this.screening} ";
        }

        #endregion

        #region Enums
        #endregion
    }
}