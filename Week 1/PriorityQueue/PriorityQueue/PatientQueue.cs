using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityQueue
{
    public class PatientQueue
    {
        private const int MAXPATIENTS = 100;

        private Patient[] patientArray;
        private int numPatients;

        public PatientQueue()
        {
            patientArray = new Patient[MAXPATIENTS];
            numPatients = 0;
        }

        //gets the highest priority and returns it
        public string pop()
        {
            string returnString;

            //checks there are patients in the list
            if (numPatients > 0)
            {
                //sorts the array
                Array.Sort(patientArray);
                //gets the highest 
                returnString = patientArray[patientArray.Length -1].toString();
                patientArray[patientArray.Length -1] = null;
                numPatients--;
            }
            else
            {
                returnString = "No Patients in Queue";
            }
            return returnString;
        }

        //adds a new patient to the queue
        public string push(string name, int priority)
        {
            if ((name == "") || (priority > 10))
            {
                return "Patient Information Needed";
            }
            else
            {
                if (numPatients < MAXPATIENTS)
                {
                    Patient newPatient = new Patient(name, priority);
                    patientArray[numPatients] = newPatient;
                    numPatients++;
                    return "Patient Added";
                }
                else
                {
                    return "Can not add patient queue full";
                }
            }
            
        }

        //displays all the patients
        public void displayAllPatients(ListBox listbox)
        {
            for(int i = 0; i < numPatients; i++)
            {
                listbox.Items.Add(patientArray[i].toString());
            }
        }

        public void addPatients()
        {
            //add new patients
            push("Jimmy", 5);
            push("Alex", 4);
            push("Carly", 3);
            push("Sarah", 2);
            push("Jason", 1);
            push("Alexa", 3);
        }
    }
}
