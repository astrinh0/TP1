/*
 * 
 * <copyright file = "Syntomns"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>4/24/2020 3:53:13 PM</date>
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
    class Syntomns
    {
        #region Member Variables

        public int idSyntomns;
        public string description;
        public Screening screening;
        public MedicalAppointment medic;
        protected Patient[] patient;

        #endregion

        #region Constructors

        public Syntomns()
        {
            idSyntomns = 0;
            description = "";
            screening = 0;


            medic = new MedicalAppointment();
            patient[0] = new Patient();
        }

        public Syntomns(string description, Screening screening, MedicalAppointment medic, Patient patient)
        {
            this.idSyntomns = GetNextID();
            this.description = description;
            this.screening = screening;


            this.medic = medic;
            this.patient[0] = patient;
        }


        #endregion

        #region Properties

        protected Patient Patient { get => patient[0]; set => patient[0] = value; }



        #endregion

        #region Functions

        public int GetNextID()
        {
            return ++this.idSyntomns;
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