using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Homework
{
    class Hospital
    {
        public string Address;
        public string Postcode;
    }
    class Employee : Hospital
    {
        public string Name;
        public string Gender;
        public string Age;
        public string Job;
    }
    class Nurse : Employee
    {
        private int Numberofcompletedbloodtests;
        private int Numberofpatientsonward;
    }
    class Patient : Hospital
    {
        public string Illness;
        public string Name;
        public int Age;
        private string Gender;
    }
    class Newborn : Patient
    {
        private bool hasAllVaccines;
        private bool isinincubator;
    }
    class Department : Hospital
    {
        private string Ward;
        private int Numberofpatients;
        public int NumberOfDoctors;
        public int NumberOfRooms;
    }
    class Paedatric : Department
    {
        private int NumberOfChildren;
        private bool HasPlayingArea;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
