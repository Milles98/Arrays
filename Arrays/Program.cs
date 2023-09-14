﻿namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. Deklarera
            //int[] scores;

            //// 2. Skapa
            //scores = new int[10];

            //int[] numbers = new int[4];
            //numbers[0] = 1;
            //numbers[1] = 3;
            //numbers[2] = 45;
            //numbers[3] = 5;

            //Console.WriteLine(numbers[2]);

            //Denna kod snutt är samma som den ovan
            //int[] numbers = new int[]
            //{
            //    1, 3, 45, 5
            //};


            //Övning array
            //Skapa en string array som heter
            // days som innehåller 6 dagar(mån - lör)
            //Du har glömt
            //söndag!Prutt!

            string[] days = { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag" };


            string[] temp = new string[7];

            int index = 0;

            foreach (string day in days)
            {
                temp[index] = day;

                if (index == days.Length - 1)
                {
                    temp[index + 1] = "Söndag";
                }
                index++;
            }

            days = temp;

            foreach (string day in days)
            {
                Console.WriteLine(day);
            }


            Console.ReadLine();
        }
    }
}