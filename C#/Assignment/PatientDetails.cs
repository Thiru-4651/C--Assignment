using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public enum Gender{Male,Female}
    public class PatientDetails
    {
        private static int _patientID=0;
        public int PatientID { get; }
        public string Password { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public PatientDetails(string password,string patientName,int age,Gender gender)
        {
            _patientID++;
            PatientID=_patientID;
            Password=password;
            PatientName=patientName;
            Age=age;
            Gender=gender;
        }
    }
}