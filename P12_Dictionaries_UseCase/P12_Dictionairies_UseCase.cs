using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_Dictionaries_UseCase
{
    internal class P12_Dictionairies_UseCase
    {

        static void Main(string[] args)
        {
            // Zähle, wie oft jede Nummer im Array vorkommt

            int[] numbers = [20, 30, 20, 50, 80, 90, 80, 10, 40, 60, 60, 50];

            Dictionary<int, int> numberCounting = new Dictionary<int, int>();

            foreach (var item in numbers)
            {
                if (numberCounting.ContainsKey(item))
                {
                    numberCounting[item]++;
                }
                else
                {
                    numberCounting[item] = 1;
                }
            }

            Console.WriteLine("Breakpoint for debugging");


        }



        
    }
}
