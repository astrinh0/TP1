﻿/*
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
    /// <summary>
    /// Classe de Paciente que herda de Pessoa
    /// </summary>
    class Patient : Person
    {
        #region Member Variables

        public int idPatient;
        protected Attended attended;
        public int[] codSyntomns;
        public int countSyntomns;


        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Patient()
        {
            idPatient = 0;
            attended = Attended.No;


            name = "";
            contact = "";
            birthday = DateTime.Today;
            gender = 0;
            codSyntomns = new int[100];
            countSyntomns = 0; 
        }

        
        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="attended"></param>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="birthday"></param>
        /// <param name="gender"></param>
        /// <param name="countSyntomns"></param>
        public Patient(Attended attended, string name, string contact, DateTime birthday, Gender gender, int countSyntomns)
        {
            this.idPatient = GetNextID();
            this.attended = Attended.No;
            this.countSyntomns = countSyntomns;




            base.name = name;
            base.contact = contact;
            base.birthday = birthday;
            base.gender = gender;

        }



        #endregion

        #region Properties
        /// <summary>
        /// Propriedades para aceder as variaveis protegidas
        /// </summary>

        protected Attended GetAttended { get => attended; set => attended = value; }

        protected int Id { get => idPatient; set => idPatient = value; }

        #endregion

        #region Functions

        /// <summary>
        /// funcao que gera automaticamente o ID
        /// </summary>
        /// <returns></returns>

        protected int GetNextID()
        {
            return ++Id;
        }



   
             



        #endregion

        #region Enums



        /// <summary>
        /// Enumerado para ver se foi atendido ou nao
        /// </summary>
        public enum Attended
        {
            No,
            Yes
        }

        #endregion
    }
}