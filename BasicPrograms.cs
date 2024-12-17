using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class BasicPrograms
    {
        public static void PrintNames()
        {
            Console.WriteLine("Harry");
            Console.WriteLine("Jack");
            Console.WriteLine("Piyush");
            Console.WriteLine("Anmol");
            Console.WriteLine("Kellen");

        }

        public static void SquareAndSum()
        {
            Console.WriteLine("Enter firstNum:");
            decimal n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter 2ndNum:");
            decimal n2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Square and Sum of num: " + ((n1 * n1) + (n2 * n2)));
        }

        public static void SquareAndDiff()
        {
            Console.WriteLine("Enter firstNum:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2ndNum:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square and Difference of num: " + ((n1 * n1) - (n2 * n2)));
        }

        public static void PrintPlaceName()
        {
            Console.WriteLine("Enter the place:");
            string place = Console.ReadLine();
            Console.WriteLine(place.ToUpper());
            Console.WriteLine(place.ToLower());
        }

        public static void PrintNum10Times()
        {
            Console.WriteLine("Enter the Num:");
            string num = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
            }
        }
    }
}