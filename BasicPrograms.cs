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

        public static void GetAverageRandomNum()
        {
            Random r = new Random();
            int[] arr = new int[5];
            for(int i = 0; i <= 4; i++)
            {
                int n = r.Next(10, 51);
                Console.Write(n + " ");
                arr[i] = n;
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("\n\nAverage: " + (sum/arr.Length));
        }

        public static void AreaPeriOfCircle()
        {
            Console.WriteLine("Enter the diameter of a circle");
            double dia = Convert.ToInt64(Console.ReadLine());
            double radius = dia / 2;

            Console.WriteLine("Area is: " + (radius * 3.14 * radius)+" sq. unit");
            Console.WriteLine("Perimeter is: " + (2 * 3.14 * radius)+" unit");

        }

        public static void GenerateNextDay()
        {
            Console.Write("Input a year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Input a month [1-12]: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Input a day [1-31]: ");
            int day = int.Parse(Console.ReadLine());
            DateTime currentDate = new DateTime(year, month, day);

            DateTime nextDate = currentDate.AddDays(1);

            Console.WriteLine($"The next date is [yyyy-mm-dd] {nextDate:yyyy-MM-dd}");
        }

        public static void GenerateNumbers(int n)
        {
            if(n <= 100)
            {
                Console.Write(n + " ");
                n++;
            }
            else
            {
                return;
            }
            GenerateNumbers(n);
        }

    }
}