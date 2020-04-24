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
        public int codMedic;
        public int[] codPatient = new int[100];

        #endregion

        #region Constructors

        public Syntomns()
        {
            idSyntomns = 0;
            description = "";
            screening = Screening.NU;


            codMedic = 0; 
            codPatient[0] = 0;
        }

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


        



        public void AddCodPatient(Syntomns syntomns, int codPatient)
        {
            for (int i = 0; i < syntomns.codPatient.Length; i++)
            {
                if (syntomns.codPatient[i] == 0)
                {
                    syntomns.codPatient[i] = codPatient;
                    break;
                }
            }
        }


        public int GetNextID()
        {
            return ++this.idSyntomns;
        }


        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} ", this.idSyntomns, this.description, this.screening, this.codMedic);
        }

        public void PrintArray(int[] codPatient)
        {
            foreach (int i in codPatient)
            {
                Console.WriteLine("The list of patients is: {0}", i);
            }

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