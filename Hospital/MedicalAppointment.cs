/*
 * 
 * <copyright file = "MedicalAppointment"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>4/24/2020 3:54:23 PM</date>
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
    class MedicalAppointment
    {
        #region Member Variables

        public int idMedicalAppointment;
        public string typeOfMedical;
        public int codMedic;
        public int codPatient;



        #endregion

        #region Constructors

        public MedicalAppointment()
        {
            idMedicalAppointment = 0;
            typeOfMedical = "";
            codMedic = 0;
            codPatient = 0;
        }

        public MedicalAppointment(string typeOfMedical, int codMedic, int codPatient)
        {
            this.idMedicalAppointment = GetNextID();
            this.typeOfMedical = typeOfMedical;

            this.codMedic = codMedic;
            this.codPatient = codPatient;

        }



        #endregion

        #region Properties


        #endregion

        #region Functions

        public int GetNextID()
        {
            return ++this.idMedicalAppointment;
        }





        #endregion

        #region Enums
        #endregion
    }
}