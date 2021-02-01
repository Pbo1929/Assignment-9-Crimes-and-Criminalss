using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_Crimes_and_Criminals
{
    class Criminal
    {
        private string Name;
        private int Age;
        private Crime[] CrimesComitted;

        public Criminal(string name, int age)
        {
            Name = name;
            Age = age;
            CrimesComitted = new Crime[3];
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public bool AddCrime(Crime CrimeToAdd)
        {
            int CrimesCount = CountCrimes();
            if (CrimesCount < CrimesComitted.Length)
            {
                CrimesComitted[CrimesCount] = CrimeToAdd;
                return true;
            }
            return false;
        }

        public int CountCrimes()
        {
            for (int i = 0; i < CrimesComitted.Length; i++)
            {
                if (CrimesComitted[i] == null) return i;
            }

            return CrimesComitted.Length;
        }

        public Crime GetCrime(int i)
        {
            if (i <= CountCrimes())
            {
                return CrimesComitted[i];
            }
            else
            {
                return null;
            }
        }
    }
}