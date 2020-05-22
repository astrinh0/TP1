/*
 * 
 * <copyright file = "Urgency"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>4/25/2020 3:06:45 PM</date>
 * <description></description>
 * 
 */




using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HospitalBarcelos
{
    [Serializable]

    public class Urgency
    {
        #region Member Variables

        private List<Patient> patients = new List<Patient>();
        private List<Staff> staff = new List<Staff>();
        private List<MedicalAppointment> medicalAppointments = new List<MedicalAppointment>();

        private const string PATHPATIENTS = @".\Patients.bin";
        private const string PATHSTAFF = @".\Staff.bin";
        private const string PATHMEDICALAPPOINTMENTS = @".\MedicalAppointments.bin";




        #endregion

        #region Constructors

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Urgency()
        {

        }


        /// <summary>
        /// Construtor parametros
        /// </summary>
        /// <param name="patients"></param>
        /// <param name="staff"></param>
        /// <param name="medicalAppointments"></param>
        public Urgency(List<Patient> patients, List<Staff> staff, List<MedicalAppointment> medicalAppointments)
        {

            this.patients = patients;
            this.staff = staff;
            this.medicalAppointments = medicalAppointments;


        }




        #endregion

        #region Properties

        public List<Patient> Patients { get => patients; set => patients = value; }

        public List<Staff> Staff { get => staff; set => staff = value; }

        public List<MedicalAppointment> MedicalAppointments { get => medicalAppointments; set => medicalAppointments = value; }




        #endregion

        #region Functions

        /// <summary>
        /// gravar em ficheiros as listas
        /// </summary>
        /// <returns></returns>
        public bool SavePatientsToFile()
        {
            try
            {
                FileStream fs = new FileStream(PATHPATIENTS, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(fs, patients);
                fs.Close();

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return false;
        }

        public bool SaveStaffToFile()
        {
            try
            {
                FileStream fs = new FileStream(PATHSTAFF, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(fs, staff);
                fs.Close();

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return false;
        }

        public bool SaveMedicalAppointmentsToFile()
        {
            try
            {
                FileStream fs = new FileStream(PATHMEDICALAPPOINTMENTS, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(fs, medicalAppointments);
                fs.Close();

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return false;
        }



        /// <summary>
        /// Carregar para as listas respectivas
        /// </summary>
        public void LoadPatientsFromFile()
        {

            

            try
            {
                FileStream fs = new FileStream(PATHPATIENTS, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                if (File.Exists(PATHPATIENTS))
                {

                    patients = (List<Patient>)bin.Deserialize(fs);
                }
                else
                {
                    fs = File.Create(PATHPATIENTS);
                    bin.Serialize(fs, patients);
                }
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            //fs.Close();

        }

        public void LoadStaffFromFile()
        {

            

            try
            {
                FileStream fs = new FileStream(PATHSTAFF, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();

                if (File.Exists(PATHSTAFF))
                {
                    staff = (List<Staff>)bin.Deserialize(fs);
                }
                else
                {
                    fs = File.Create(PATHSTAFF);
                    bin.Serialize(fs, staff);
                }
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


        }

        public void LoadMedicalAppointmentFromFile()
        {

            

            try
            {
                FileStream fs = new FileStream(PATHMEDICALAPPOINTMENTS, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();

                if (File.Exists(PATHMEDICALAPPOINTMENTS))
                {
                    medicalAppointments = (List<MedicalAppointment>)bin.Deserialize(fs);
                }
                else
                {
                    fs = File.Create(PATHMEDICALAPPOINTMENTS);
                    bin.Serialize(fs, staff);
                }
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            

        }




        /// <summary>
        /// Adiciona doenca ao paciente e a sua respectiva pulseira
        /// </summary>
        /// <param name="patients"></param>
        /// <param name="idPatient"></param>
        /// <returns></returns>
        public bool AddDiseaseToPatient(List<Patient> patients, int idPatient)
        {
            var today = DateTime.Today;
            Patient.Screening ScreenAux;

            foreach (var patient in patients)
            {
                if (patient != null && patient.IdPatient == idPatient)
                {
                    Console.WriteLine("Diga a doenca");
                    patient.Disease = Console.ReadLine();
                    Console.WriteLine("Diga a cor da pulseira (R) (O) (Y) (G)");
                    ScreenAux = (Patient.Screening)Enum.Parse(typeof(Patient.Screening), Console.ReadLine());
                    var aux = today.Year - patient.Birthday.Year;
                    if (aux > 65 && ScreenAux != Patient.Screening.R)
                    {
                        patient.Screen = ScreenAux + 1;
                    }
                    else
                    {
                        patient.Screen = ScreenAux;
                    }
                    return true;
                }
            }
            return false;

        }





        /// <summary>
        /// procura paciente na lista
        /// </summary>
        /// <param name="urgency"></param>
        /// <param name="idPatient"></param>
        /// <returns></returns>
        public Patient FindPatientByIdinList(Urgency urgency, int idPatient)
        {
            foreach (var patient in urgency.patients)
            {
                if (patient.FindPatientById(patient, idPatient) != null)
                {
                    return patient.FindPatientById(patient, idPatient);
                }
            }
            return null;
        }




        /// <summary>
        /// procura staff na lista
        /// </summary>
        /// <param name="urgency"></param>
        /// <param name="idStaff"></param>
        /// <returns></returns>
        public Staff FindMedicByIdinList(Urgency urgency, int idStaff)
        {
            foreach (var medic in urgency.staff)
            {
                if (medic.FindStaffById(medic, idStaff) != null)
                {
                    return medic.FindStaffById(medic, idStaff);
                }
            }
            return null;
        }

        /// <summary>
        /// procura consulta na lista
        /// </summary>
        /// <param name="urgency"></param>
        /// <param name="idMedicalAppointment"></param>
        /// <returns></returns>
        public MedicalAppointment FindMedicalAppointmentByIdinList(Urgency urgency, int idMedicalAppointment)
        {
            foreach (var medicalAppointment in urgency.MedicalAppointments)
            {
                if (medicalAppointment.FindMedicalAppointmentById(medicalAppointment, idMedicalAppointment) != null)
                {
                    return medicalAppointment.FindMedicalAppointmentById(medicalAppointment, idMedicalAppointment);
                }

            }
            return null;
        }











        /// <summary>
        /// regiao dos prints para a consola!
        /// </summary>

        #region Prints

        public void PrintAllStaff(List<Staff> listStaff)
        {
            foreach (var staff in listStaff)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9}", staff.IdStaff, staff.Name, staff.Job,
                                                                    staff.NumberSNS, staff.Work, staff.GenderP, staff.Birthday.ToShortDateString(),
                                                                    staff.Contact, staff.Address, staff.GetActive);
            }

        }

        public void PrintAllPatients(List<Patient> patients)
        {
            foreach (var patient in patients)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9} - {10} - {11} - {12}", patient.IdPatient, patient.Name, patient.Entrace.ToShortDateString(), patient.Leave.ToShortDateString(), patient.Screen, patient.GetAttended, patient.Disease,
                                                                    patient.NumberSNS, patient.GenderP, patient.Birthday.ToShortDateString(),
                                                                    patient.Contact, patient.Address, patient.GetActive);

            }

        }

        public void PrintAllMedicalAppointments(List<MedicalAppointment> medicalAppointments)
        {
            foreach (var medicalAppointment in medicalAppointments)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4}", medicalAppointment.IdMedicalAppointment, medicalAppointment.CodPatient, medicalAppointment.CodStaff, medicalAppointment.TypeOfMedical,
                                                                            medicalAppointment.Date.ToShortDateString());
            }

        }

        public void PrintMedicalAppointment(MedicalAppointment medicalAppointment)
        {
            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", medicalAppointment.IdMedicalAppointment, medicalAppointment.CodPatient, medicalAppointment.CodStaff, medicalAppointment.TypeOfMedical,
                                                                        medicalAppointment.Date.ToShortDateString());

        }

        public void PrintPatient(Patient patient)
        {


            Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9} - {10} - {11} - {12}", patient.IdPatient, patient.Name, patient.Entrace.ToShortDateString(), patient.Leave.ToShortDateString(), patient.Screen, patient.GetAttended, patient.Disease,
                                                                patient.NumberSNS, patient.GenderP, patient.Birthday.ToShortDateString(),
                                                                patient.Contact, patient.Address, patient.GetActive);


        }

        public void PrintStaff(Staff staff)
        {

            Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9}", staff.IdStaff, staff.Name, staff.Job,
                                                                staff.NumberSNS, staff.Work, staff.GenderP, staff.Birthday.ToShortDateString(),
                                                                staff.Contact, staff.Address, staff.GetActive);
        }


        #endregion






        #endregion

        #region Enums
        #endregion
    }
}


