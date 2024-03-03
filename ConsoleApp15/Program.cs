using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 50;
            int maxValue = 150;
            int rangeMin = 10;
            int rangeMax = 26;
            int number = 0;
            int randomNumber = random.Next(rangeMin, rangeMax);
            Console.WriteLine("случайное число " + randomNumber);

            for (int i = 0; i <= maxValue; i += randomNumber)
            { 
                if (i >= minValue)
                {
                    ++number;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("количество кратных чисел: " + number);
        }
    }
}
