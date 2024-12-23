using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class ArrayBased
    {
        public static int[] CreateArray()
        {
            Console.WriteLine("Enter the size of an Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element for " + (i + 1) + " position: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }

            Console.WriteLine("\nThe Elements are: ");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            return arr;
        }
        public static void FindFirstRepeatedElement(int[] arr)
        {
            int index = 0;

            for(int i = 0;i < arr.Length;i++)
            {
                for(int j = i+1; i<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        index = i;
                        Console.WriteLine("First Repeated Element is: " + arr[i]);
                        return;
                    }
                }
            }
        }
    }
}
