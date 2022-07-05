using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_Polymorphism
{
    class MedicalRecords
    {
        private string strPatientName;
        private float fltMedicalFees;
        public MedicalRecords(string strPatientName, float fltMedicalFees)
        {
            this.strPatientName = strPatientName; //this.strPatientName keyword <this> indicate that the name is refer private variable 
            this.fltMedicalFees = fltMedicalFees; 
        }
        public float CelMedicalFees()
        {
            return fltMedicalFees;
        }
        public float CalMedicalFees(string test)
        {
            if (test =="Hapatities")
            {
                fltMedicalFees = fltMedicalFees + 17.7f;
            }
            else if (test =="Cholesterol")
            {
                fltMedicalFees = fltMedicalFees + 25f;
            }
            else //if (test == "Diabetes")
            {
                fltMedicalFees = fltMedicalFees + 20f;
            }
            return fltMedicalFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter patient's name: ");
            string patient = Console.ReadLine();
            Console.Write("Enter patient's Fees: ");
            float fee = float.Parse(Console.ReadLine());
            MedicalRecords mObj = new MedicalRecords(patient, fee);

        }
    }
}
