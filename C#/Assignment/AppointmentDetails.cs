using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class AppointmentDetails
    {
        private static int _appointmentID=0;
        public int AppointmentID { get;  }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Date { get; set; }
        public string Problem { get; set; }

        public AppointmentDetails(int patientID,int doctorID,DateTime date,string problem)
        {
            _appointmentID++;
            AppointmentID=_appointmentID;
            PatientID=patientID;
            DoctorID=doctorID;
            Date=date;
            Problem=problem;
        }
    }
}