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
using System.Threading;
using System.Threading.Tasks;

namespace HospitalBarcelos
{

    /// <summary>
    /// Classe de Staff que herda de Pessoa.
    /// </summary>
    public class Staff : Person
    {
        #region Member Variables

        private int idStaff;
        private string job;
        private Working working;

        private static int globalId;


        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Staff()
        {
            idStaff = 0;
            job = "";
            working = Working.N;

            Name = "";
            contact = "";
            Birthday = DateTime.Today;
            GenderP = Gender.ND;
            active = Active.No;

        }

        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="job"></param>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="birthday"></param>
        /// <param name="gender"></param>
        public Staff(string job, string name, string contact, DateTime birthday, Gender gender, Working working, string address, int numberSNS)
        {
            this.IdStaff = Interlocked.Increment(ref globalId);
            this.job = job;
            this.working = working;
 



            base.Name = name;
            base.Contact = contact;
            base.Birthday = birthday;
            base.GenderP = gender;
            base.Address = address;
            base.GetActive = Active.Yes;
            base.NumberSNS = numberSNS;
            

        }



        #endregion

        #region Properties

        /// <summary>
        /// Propriedades para aceder as variaveis protegidas
        /// </summary>
        public int IdStaff { get => idStaff; set => idStaff = value; }

        public string Job { get => job ; set => job = value; }

        public Working Work { get => working; set => working = value; }


        #endregion

        #region Functions

        public Staff FindStaffById(Staff staff, int idStaff)
        {
            if (staff != null && staff.idStaff == idStaff)
            {
                return staff;
            }
            return null;
        }

        public Staff FindStaffByName(Staff staff, string name)
        {
            if (staff != null && staff.Name == name)
            {
                return staff;
            }
            return null;
        }
        public Staff ShowActiveStaff(Staff staff)
        {
            if (staff != null && staff.active == Active.Yes)
            {
                return staff;
            }
            return null;
        }

        public bool ChangeAddress(Staff staff, string address, int idStaff)
        {
            if (staff != null && staff.IdStaff == idStaff)
            {
                staff.address = address;
                return true;
            }

            return false;
        }

        public bool StartWorking(Staff staff, int idStaff)
        {
            if (staff != null && staff.IdStaff == idStaff)
            {
                staff.working = Working.Y;
                return true;
            }

            return false;
        }

        public bool LeaveWorking(Staff staff, int idStaff)
        {
            if (staff != null && staff.IdStaff == idStaff)
            {
                staff.working = Working.N;
                return true;
            }

            return false;
        }

        public bool Fired(Staff staff, int idStaff)
        {
            if (staff != null && staff.IdStaff == idStaff)
            {
                staff.active = Active.No;
                return true;
            }

            return false;
        }





        #endregion

        #region Enums

        public enum Working
        {
            N,
            Y
        }
        #endregion
    }
}