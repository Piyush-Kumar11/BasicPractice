﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BasicPrograms.PrintNames();
            //BasicPrograms.SquareAndSum();
            //BasicPrograms.SquareAndDiff();
            //BasicPrograms.PrintPlaceName();
            //BasicPrograms.PrintNum10Times();


            //1 Write a program that checks if a given string has all unique characters
            //if (ClassWork.CheckUnique())
            //{
            //    Console.WriteLine("No duplicates");
            //}
            //else
            //{
            //    Console.WriteLine("Duplicates Found!");
            //}


            //2 Write a program that generates and prints all prime numbers up to a given number n. 
            //ClassWork.PrintPrime(100);


            //3 Write a program that checks if two given strings are anagrams of each other.
            //Console.WriteLine("Enter the first string:");
            //string str1 = Console.ReadLine();

            //Console.WriteLine("Enter the second string:");
            //string str2 = Console.ReadLine();

            //if (ClassWork.CheckAnagrams(str1, str2))
            //    Console.WriteLine("The strings are anagrams.");
            //else
            //    Console.WriteLine("The strings are not anagrams.");


            //4 Write a program that finds the longest substring in a given string that does not contain any repeating characters. 
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string result = ClassWork.LongestUniqueSubstring(input);
            Console.WriteLine("Longest unique substring: " + result);

            //5 Write a program that reverses the words in a given sentence without changing the order of the words.
            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();

            //string result = ClassWork.ReverseEachWord(sentence);

            //Console.WriteLine("The sentence with reversed words is:");
            //Console.WriteLine(result);




        }
    }
}
