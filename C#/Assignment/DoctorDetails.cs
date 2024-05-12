using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class DoctorDetails
    {
        private static int _doctorID = 0;
        public int DoctorID { get; }
        public string DoctorName { get; set; }
        public string Department { get; set; }
        public DoctorDetails(string doctorname, string department)
        {
            _doctorID++;
            DoctorID=_doctorID;
            DoctorName=doctorname;
            Department=department;
        }
    }
}
