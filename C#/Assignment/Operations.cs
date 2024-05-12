using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace Assignment
{
    public class Operations
    {
        public static PatientDetails currentloggedinpatient;
        public static List<DoctorDetails> doctorList = new List<DoctorDetails>();
        public static List<PatientDetails> patientList = new List<PatientDetails>();
        public static List<AppointmentDetails> appointmentList = new List<AppointmentDetails>();

        public static void Mainmenu()
        {
            bool flag = true;
            do
            {
                //MainMenu entrance
                System.Console.WriteLine("**************************MainMenu**************************\n\n1.Registration\n2.Login \n3.Exit");
                System.Console.Write("Enter the option from the MainMenu: ");
                int mainOption = int.Parse(Console.ReadLine());

                switch (mainOption)
                {
                    case 1:
                        {
                            System.Console.WriteLine("**************************Registration**************************");
                            Registration();
                            break;
                        }

                    case 2:
                        {
                            System.Console.WriteLine("**************************Login**************************");
                            Login();
                            break;
                        }

                    case 3:
                        {
                            flag = false;
                            System.Console.WriteLine("Thank you for using this application. Have a nice day :) ");
                            System.Console.WriteLine("**************************Application Closing....**************************");
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine("Invalid option");
                            break;
                        }
                }
            } while (flag);
        }

        public static void Registration()
        {
            //Getting the patien details

            System.Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter your Password: ");
            string password = Console.ReadLine();

            System.Console.Write("Enter the Age: ");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("Enter you Gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            // while (!(balance >= 15))
            // {
            //     System.Console.WriteLine("Low Balance..Minimum Balance 15 required ");
            //     System.Console.Write("Re-Enter the Balance: ");
            //     balance = int.Parse(Console.ReadLine());
            // }

            //Creating the new patientdetails object
            PatientDetails newPatient = new PatientDetails(password, name, age, gender);

            //Adding the object to the list
            patientList.Add(newPatient);

            //Printing the PatientID to the patient
            System.Console.WriteLine("Registration Successfull  :) \nYour PatientID is: " + newPatient.PatientID);

        }

        public static void Login()
        {
            System.Console.Write("Enter your PatientID: ");
            int userEnteredPatientID = int.Parse(Console.ReadLine());

            System.Console.Write("Enter the password: ");
            string password = Console.ReadLine();

            int count = 0;

            //Checking is it valid or not
            foreach (PatientDetails user in patientList)
            {
                if (user.PatientID.Equals(userEnteredPatientID) && user.Password.Equals(password))
                {
                    //Welcom message
                    System.Console.WriteLine($"Welcome {user.PatientName} you are logged in sucessfully :) ");
                    count = 1;

                    //Assinging the patient details to the globally
                    currentloggedinpatient = user;

                    //SubMenu method 
                    SubMenu();
                    break;
                }
            }

            //for not valid id
            if (count == 0)
            {
                System.Console.WriteLine("Invalid PatientID");
            }

        }

        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                //Submenu Entrance
                System.Console.WriteLine("\n**************************SubMenu**************************\n\na.Book Appointment\nb.View Appointment details\nc.Edit MyProfile\nd.Exit\n");

                //Getting the option from the user 
                System.Console.Write("Enter the option from SubMenu:");
                char subOption = char.Parse(Console.ReadLine().ToLower());

                //Switching the option
                switch (subOption)
                {
                    case 'a':
                        {
                            System.Console.WriteLine("**************************Book Appointment**************************");
                            Book();
                            break;
                        }

                    case 'b':
                        {
                            System.Console.WriteLine("**************************View Appointment details**************************");
                            Appointmentdetails();
                            break;
                        }

                    case 'c':
                        {
                            System.Console.WriteLine("**************************Edit MyProfile**************************");
                            Edit();
                            break;
                        }

                    case 'd':
                        {
                            flag = false;
                            System.Console.WriteLine("Exited Successfully.You are Redirected to MainMenu");
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine("Invalid Option");
                            break;
                        }
                }
            } while (flag);
        }

        public static void Book()
        {
            int[] today = new int[] { 0, 0, 0, 0, 0 };
            char tocontinue = 'Y';
            do
            {
                System.Console.WriteLine("\n1.Anaesthesiology\n2.Cardiology\n3.Diabetology\n4.Anaesthesiology\n5.Neonatology\n\nSelect the department : ");
                int department = int.Parse(Console.ReadLine());


                if (today[department - 1] < 2)
                {
                    System.Console.Write("Enter the problem: ");
                    string problem = Console.ReadLine();

                    today[department - 1]++;
                    AppointmentDetails appointment = new AppointmentDetails(currentloggedinpatient.PatientID, department, DateTime.Now, problem);

                    appointmentList.Add(appointment);
                    System.Console.WriteLine($"Appointment is Confirmed for date {DateTime.Now.ToString("dd/MM/yyyy")}");
                }
                else
                {
                    System.Console.WriteLine("Doctor was not available today!");
                }
                System.Console.Write("Do you want to continue book (Y/N):");
                tocontinue=char.Parse(Console.ReadLine());
            } while (tocontinue == 'Y');
        }

        public static void Appointmentdetails()
        {
            bool flag=true;
            foreach (AppointmentDetails appointment in appointmentList)
            {
                if (appointment.PatientID == currentloggedinpatient.PatientID)
                {
                    flag=false;
                    System.Console.WriteLine($"{appointment.AppointmentID}\t{appointment.PatientID}\t{appointment.DoctorID}\t{appointment.Date.ToString("dd/MM/yyyy")}\t{appointment.Problem}");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Today You have no appointments");
            }
        }
        public static void Edit()
        {
            System.Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter your Password: ");
            string password = Console.ReadLine();

            System.Console.Write("Enter the Age: ");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("Enter you Gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            currentloggedinpatient.PatientName = name;
            currentloggedinpatient.Password = password;
            currentloggedinpatient.Age = age;
            currentloggedinpatient.Gender = gender;

            System.Console.WriteLine("Your Profile Has been EDited successfully");

            foreach (PatientDetails patient in patientList)
            {
                if(patient.PatientID==currentloggedinpatient.PatientID)
                {
                System.Console.WriteLine($"{patient.Password}\t{patient.PatientName}\t{patient.Age}\t{patient.Gender}");
                }
            }
        }
        public static void AddingDefaultData()
        {
            //             1	Nancy	Anaesthesiology
            // 2	Andrew	Cardiology
            // 3	Janet	Diabetology
            // 4	Margaret	Neonatology
            // 5	Steven	Nephrology
            DoctorDetails doctor1 = new DoctorDetails("Nancy", "Anaesthesiology");
            DoctorDetails doctor2 = new DoctorDetails("Andrew", "Cardiology");
            DoctorDetails doctor3 = new DoctorDetails("Janet", "Diabetology");
            DoctorDetails doctor4 = new DoctorDetails("Nancy", "Anaesthesiology");
            DoctorDetails doctor5 = new DoctorDetails("Margaret", "Neonatology");

            doctorList.Add(doctor1);
            doctorList.Add(doctor2);
            doctorList.Add(doctor3);
            doctorList.Add(doctor4);
            doctorList.Add(doctor5);


            // 1	welcome	Robert	40	Male
            // 2	welcome	Laura	36	Female
            // 3	welcome	Anne	42	Female

            PatientDetails patient1 = new PatientDetails("welcome", "Robert", 40, Gender.Male);
            PatientDetails patient2 = new PatientDetails("welcome", "Laura", 36, Gender.Female);
            PatientDetails patient3 = new PatientDetails("welcome", "Anne", 42, Gender.Female);

            patientList.Add(patient1);
            patientList.Add(patient2);
            patientList.Add(patient3);

            //             1	1	2	8/3/2012	Heart problem
            // 2	1	5	8/3/2012	Spinal cord injury
            // 3	2	2	8/3/2012	Heart attack

            AppointmentDetails appointment1 = new AppointmentDetails(1, 2, new DateTime(2012, 3, 8), "Heart problem");
            AppointmentDetails appointment2 = new AppointmentDetails(1, 5, new DateTime(2012, 3, 8), "Spinal cord injury");
            AppointmentDetails appointment3 = new AppointmentDetails(2, 2, new DateTime(2012, 3, 8), "Heart attack");

            appointmentList.Add(appointment1);
            appointmentList.Add(appointment2);
            appointmentList.Add(appointment3);

            // foreach (DoctorDetails doctor in doctorList)
            // {
            //     System.Console.WriteLine($"{doctor.DoctorID}\t{doctor.DoctorName}\t{doctor.Department}");
            // }




        }
    }
}