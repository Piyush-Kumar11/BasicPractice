using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicPractice
{
    internal class NumberBased
    {

        //Write a Program to find the first repeated element in the array(read elements of the array from the user and then find the first repeated element in a one-dimensional array)


        //Write a Program to shift all zero to the end of array.
        public static void ShiftZerosToEnd()
        {
            int[] ar = { 23,4,0,2,0,89};
            int[] ar2 = new int[ar.Length];

            int j = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                if (ar[i] != 0)
                {
                    ar2[j] = ar[i];
                    j++;
                }
            }

            foreach(int i in ar2)
            {
                Console.Write(i + " ");
            }

        }

        //Write a program that takes an array of floats and returns the average of these numbers
        public static void AvgOfNumber()
        {
            float sum =0.0f;
            float[] num = { 2.5f, 5.8f, 88.4f, 52f };
            foreach (float f in num) 
            {
                sum += f;
            }
            Console.WriteLine("Avg is: " + (sum / num.Length));
        }

        //Write a Program to to Find Roots of a Quadratic Equation. (using If Else statement or switch The roots of a Quadratic Equation(ax2+bx+c) depends upon the discriminant value.)
        public static void FindRootsOfQuadratic()
        {
            Console.Write("Enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);

            Console.WriteLine("The quadratic equation is: "+a+"x^2 + "+b+"x + "+c);

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Roots are real and distinct:");
                Console.WriteLine("Root 1: "+root1);
                Console.WriteLine("Root 2: "+root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("Roots are real and equal:");
                Console.WriteLine("Root: "+root);
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("Roots are complex:");
                Console.WriteLine("Root 1: "+realPart+" + "+imaginaryPart+"i");
                Console.WriteLine("Root 2: " + realPart + " - " + imaginaryPart + "i");
            }
        }

        /* Convert a number to a string, the contents of which depend on the number's factors.
         If the number has 3 as a factor, output 'Pling'.
         If the number has 5 as a factor, output 'Plang'.
         If the number has 7 as a factor, output 'Plong'.
         If the number does not have 3, 5, or 7 as a factor, just pass the number's digits straight through. 
         (Example :28 has 7 as a factor, but not 3 or 5, so the result would be “Plong”.
         30 has both 3 and 5 as factors, but not 7, so the result would be “PlingPlang”.
         34 is not factored by 3, 5, or 7, so the result would be “34”.)
        */
        public static void ConvertNumToString()
        {
            Console.WriteLine("Enter the Num: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 3 == 0)
            {
                Console.WriteLine("Pling");
            }
            if (n % 5 == 0)
            {
                Console.WriteLine("Plang");
            }
            if (n % 7 == 0)
            {
                Console.WriteLine("Plong");
            }
            else
            {
                Console.WriteLine(n);
            }
        }

        //Write a program which can compute the factorial of a given numbers.Develop this as function and call from main.function should return factorial.
        public static void FindFactorial()
        {
            Console.WriteLine("Enter Num: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + fact);

        }

        //Write a program which will find all such numbers which are divisible by 7 but are not a multiple of 5, between 2000 and 3200 (both included).  The numbers obtained should be printed in a comma-separated sequence on a single line.
        public static void CheckNumDivisiblity()
        {
            Console.Write("The Num divisible by 7 but not 5: ");
            for(int i = 2000; i <= 3200; i++)
            {
                CheckDivisibility(i);
            }
        }

        public static void CheckDivisibility(int i)
        {
            if(i % 7==0 && i % 5 != 0)
            {
                Console.Write(i+",");
            }
        }

    }
}
