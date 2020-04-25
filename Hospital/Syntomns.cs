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

    /// <summary>
    /// Classe dos Sintomas
    /// </summary>
    class Syntomns
    {
        #region Member Variables

        public int idSyntomns;
        public string description;
        public Screening screening;
        public int codMedic;
        public int[] codPatient;

        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Syntomns()
        {
            idSyntomns = 0;
            description = "";
            screening = Screening.NU;


            codMedic = 0;

            codPatient = new int[100];
            
        }


        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="description"></param>
        /// <param name="screening"></param>
        /// <param name="codMedic"></param>

        public Syntomns(string description, Screening screening, int codMedic)
        {
            this.idSyntomns = GetNextID();
            this.description = description;
            this.screening = screening;


            this.codMedic = codMedic;
            
        }




        #endregion

        #region Properties





        #endregion

        #region Functions



        /// <summary>
        /// funcao que gera automaticamente o ID
        /// </summary>
        /// <returns></returns>


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