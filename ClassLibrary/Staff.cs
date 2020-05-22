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
using System.Threading;

namespace HospitalBarcelos
{
    [Serializable]
    /// <summary>
    /// Classe de Staff que herda de Pessoa.
    /// </summary>
    public class Staff : Person
    {
        #region Member Variables

        private int idStaff;
        private string job;
        private Working working;

        private static int globalID;


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
        /// <param name="working"></param>
        /// <param name="address"></param>
        /// <param name="numberSNS"></param>
        public Staff(string job, string name, string contact, DateTime birthday, Gender gender, Working working, string address, int numberSNS)
        {
            this.IdStaff = Interlocked.Increment(ref globalID);
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


        /// <summary>
        /// cria um novo staff
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public Staff CreateNewStaff(Staff staff)
        {
            this.IdStaff = Interlocked.Increment(ref globalID);
            Console.WriteLine("Diga o nome:\n");
            staff.Name = Console.ReadLine();
            Console.WriteLine("Diga o contacto:\n");
            staff.Contact = Console.ReadLine();
            Console.WriteLine("Diga a morada:\n");
            staff.Address = Console.ReadLine();
            Console.WriteLine("Diga a sua data de nascimento:\n");
            staff.Birthday = DateTime.TryParse(Console.ReadLine(), out DateTime aux) ? aux : DateTime.Today;
            Console.WriteLine("Diga o number de utente:\n");
            staff.NumberSNS = Int64.TryParse(Console.ReadLine(), out long aux1) ? aux1 : 0;
            Console.WriteLine("Diga o sexo:\n");
            staff.GenderP = (Staff.Gender)Enum.Parse(typeof(Staff.Gender), Console.ReadLine());
            Console.WriteLine("Diga o trabalho:\n");
            staff.Job = Console.ReadLine();
            Console.WriteLine("Está no turno?(Y)(N)");
            staff.Work = (Staff.Working)Enum.Parse(typeof(Staff.Working), Console.ReadLine());
            staff.GetActive = Staff.Active.Yes;

            return staff;

        }

        /// <summary>
        /// Encontrar Staff por ID
        /// </summary>
        /// <param name="staff"></param>
        /// <param name="idStaff"></param>
        /// <returns></returns>
        public Staff FindStaffById(Staff staff, int idStaff)
        {
            if (staff != null && staff.idStaff == idStaff)
            {
                return staff;
            }
            return null;
        }



        /// <summary>
        /// Encontrar Staff pelo nome
        /// </summary>
        /// <param name="staff"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Staff FindStaffByName(Staff staff, string name)
        {
            if (staff != null && staff.Name == name)
            {
                return staff;
            }
            return null;
        }

        /// <summary>
        /// Mostrar Activos na Urgencia
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public Staff ShowActiveStaff(Staff staff)
        {
            if (staff != null && staff.active == Active.Yes)
            {
                return staff;
            }
            return null;
        }


        /// <summary>
        /// Alterar a morada
        /// </summary>
        /// <param name="staff"></param>
        /// <param name="address"></param>
        /// <param name="idStaff"></param>
        /// <returns></returns>

        public bool ChangeAddress(Staff staff, string address, int idStaff)
        {
            if (staff != null && staff.IdStaff == idStaff)
            {
                staff.address = address;
                return true;
            }

            return false;
        }


        /// <summary>
        /// Flag para se está no turno
        /// </summary>
        /// <param name="staff"></param>
        /// <param name="idStaff"></param>
        /// <returns></returns>
        public bool StartWorking(Staff staff, int idStaff)
        {
            if (staff != null && staff.IdStaff == idStaff)
            {
                staff.working = Working.Y;
                return true;
            }

            return true;
        }


        /// <summary>
        /// flag para tirar do turno
        /// </summary>
        /// <param name="staff"></param>
        /// <param name="idStaff"></param>
        /// <returns></returns>
        public bool LeaveWorking(Staff staff, int idStaff)
        {
            if (staff != null && staff.IdStaff == idStaff)
            {
                staff.working = Working.N;
                return true;
            }

            return false;
        }


        /// <summary>
        /// Remover staff mantendo a sua integridade
        /// </summary>
        /// <param name="staff"></param>
        /// <param name="idStaff"></param>
        /// <returns></returns>
        public bool FiredOrRemoved(Staff staff, int idStaff)
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


        /// <summary>
        /// flag para se está no turno ou não
        /// </summary>
        public enum Working
        {
            N,
            Y
        }
        #endregion
    }
}