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
using System.Linq;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBarcelos
{
    /// <summary>
    /// Classe que organiza todas as classes, 
    /// defini esta classe para definir os arrays que precisava e que estao ligados
    /// </summary>
    public class Urgency
    {
        #region Member Variables
        
        private List<Patient> patients = new List<Patient>();
        private List<Staff> staff = new List<Staff>();
        private List<MedicalAppointment> medicalAppointments = new List<MedicalAppointment>();

        private const string PATHPATIENTS = @".\Patients.csv";
        private const string PATHSTAFF = @".\Staff.csv";
        private const string PATHMEDICALAPPOINTMENTS = @".\MedicalAppointments.csv";




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
     /// gravar em ficheiros a lista de pacientes
     /// </summary>
     /// <returns></returns>
        public bool SavePatientsToFile()
        {
            try
            {
                List<string> output = new List<string>();

                foreach (var patient in Patients)
                {
                    output.Add(patient.IdPatient + ";" + patient.Name + ";" + patient.NumberSNS + ";" + patient.Contact + ";" + patient.Address + ";" +
                        patient.Birthday + ";" + patient.GenderP + ";" + patient.GetActive + ";" + patient.GetAttended + ";" + patient.Disease + ";" + patient.Screen + ";" + patient.Entrace + ";" + patient.Leave);
                }

                File.WriteAllLines(PATHPATIENTS, output);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return false;
        }


        /// <summary>
        /// Carregar para lista os pacientes do ficheiro
        /// </summary>
        public void LoadPatientsFromFile()
        {
            List<string> lines = File.ReadAllLines(PATHPATIENTS).ToList();

            foreach (var line in lines)
            {
                string[] entry = line.Split(';');

                Patient patient = new Patient();

                patient.IdPatient = Convert.ToInt32(entry[0]);
                patient.Name = entry[1];
                patient.NumberSNS = Convert.ToInt32(entry[2]);
                patient.Contact = entry[3];
                patient.Address = entry[4];
                patient.Birthday = DateTime.TryParse(entry[5], out DateTime aux) ? aux : DateTime.Today; 
                patient.GenderP = (Patient.Gender)Enum.Parse(typeof(Patient.Gender), entry[6]);
                patient.GetActive = (Patient.Active)Enum.Parse(typeof(Patient.Active), entry[7]);
                patient.GetAttended = (Patient.Attended)Enum.Parse(typeof(Patient.Attended), entry[8]);
                patient.Disease = entry[9];
                patient.Screen = (Patient.Screening)Enum.Parse(typeof(Patient.Screening), entry[10]);
                patient.Entrace = DateTime.TryParse(entry[11], out DateTime aux1) ? aux1 : DateTime.Today;
                patient.Leave = DateTime.TryParse(entry[12], out DateTime aux2) ? aux2 : DateTime.Today;
                patient.GlobalID++;

                Patients.Add(patient);
                
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
                    Console.WriteLine("Diga a cor da pulseira (RED) (ORANGE) (YELLOW) (GREEN)");
                    ScreenAux = (Patient.Screening)Enum.Parse(typeof(Patient.Screening), Console.ReadLine());
                    var aux = today.Year - patient.Birthday.Year;
                    if (aux > 50 && ScreenAux != Patient.Screening.R)
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