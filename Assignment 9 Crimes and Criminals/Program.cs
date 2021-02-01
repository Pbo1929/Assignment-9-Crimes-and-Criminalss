using System;

namespace Assignment_9_Crimes_and_Criminals
{
    class Program
    {
        static void Main(string[] args)
        {

            Criminal[] criminals = new Criminal[3];
            criminals[0] = new Criminal("Joel", 31);
            criminals[1] = new Criminal("Jesus", 51);
            criminals[2] = new Criminal("John", 26);

            criminals[0].AddCrime(new Crime(DateTime.Parse("01/01/2020"), "Ascot", "Robbery"));
            criminals[1].AddCrime(new Crime(DateTime.Parse("02/01/2020"), "Ascot", "Jaywalking"));
            criminals[2].AddCrime(new Crime(DateTime.Parse("03/01/2020"), "Ascot", "Abusing"));


            for (int i = 0; i < criminals.Length; i++)
            {
                int TotalCrime = criminals[i].CountCrimes();

                for (int x = 0; x < TotalCrime; x++)
                {
                    Console.WriteLine("NAME:" + criminals[i].GetName() + "   " + "CRIME:" + criminals[i].GetCrime(x).GetAct() + "   " + 
                        "LOCATION:" +  criminals[i].GetCrime(x).GetLocation() + "   " + "DATE:" + criminals[i].GetCrime(x).GetDate());
                }

            }
        }
    }
}
            //Add crimes to all 3 criminals.
            //Write a for loop below that loops through all 3 criminals, and loops through each crime ...
            //for each criminal and prints all of the information.
            //Extension - if they have max crimes  show message " Due for execution " 
