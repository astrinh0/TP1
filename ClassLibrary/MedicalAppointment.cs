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

namespace HospitalBarcelos
{
    /// <summary>
    /// Classe das consultas
    /// </summary>
    public class MedicalAppointment
    {
        #region Member Variables

        public int idMedicalAppointment;
        public string typeOfMedical;
        public int codMedic;
        public int codPatient;



        #endregion

        #region Constructors
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public MedicalAppointment()
        {
            idMedicalAppointment = 0;
            typeOfMedical = "";
            codMedic = 0;
            codPatient = 0;
        }


        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="typeOfMedical"></param>
        /// <param name="codMedic"></param>
        /// <param name="codPatient"></param>
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


        /// <summary>
        /// Funcao de gerar ID automatico
        /// </summary>
        /// <returns></returns>
        public int GetNextID()
        {
            return ++this.idMedicalAppointment;
        }


        /// <summary>
        /// Funcao que imprime a classe.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.idMedicalAppointment} - {this.typeOfMedical} - {this.codMedic} - {this.codPatient}";
        }



        #endregion

        #region Enums
        #endregion
    }
}