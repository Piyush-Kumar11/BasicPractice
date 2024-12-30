using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class ClassWork
    {
        //1. Write a program that merges two sorted arrays into a single sorted array.
        public static void MergeArray()
        {
            int[] arr = CreateArray();
            Console.WriteLine("===================");
            int[] ar2 = CreateArray();

            int n1 = arr.Length;
            int n2 = ar2.Length;

            int[] result = new int[n1 + n2];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < n1 && j < n2)
            {
                if (arr[i] <= ar2[j])
                {
                    result[k++] = arr[i++];
                }
                else
                {
                    result[k++] = ar2[j++];
                }
            }

            while (i < n1)
            {
                result[k++] = arr[i++];
            }

            while (j < n2)
            {
                result[k++] = ar2[j++];
            }

            Console.WriteLine("Merged Sorted Array:");
            foreach (int val in result)
            {
                Console.Write(val+" ");
            }
            Console.WriteLine("\n==============");
        }

        //2. Write a program that finds the second largest element in an array of integers.
        public static void SecondLargest()
        {
            int[] result = CreateArray();

            int h1 = int.MinValue;
            int h2 = int.MinValue;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > h1)
                {
                    h2 = h1;
                    h1 = result[i];
                }
                else if (result[i] > h2 && result[i] != h1)
                {
                    h2 = result[i];
                }
            }
            Console.WriteLine("Second Highest is: " + h2);
        }

        //3. Write a program that removes duplicate elements from an array and prints the result
        public static void RemoveDuplicates()
        {
            int[] arr = CreateArray();

            Console.WriteLine("\nAfter removing duplicates: ");
            var result = arr.Distinct();
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        //4. Write a program that finds the missing number in an array of integers from 1 to n.
        public static void FindMissingNumber()
        {
            int[] arr = CreateArray(); 
            int n = arr.Length + 1; 

            int expectedSum = n * (n + 1) / 2;

            int actualSum = arr.Sum();

            int missingNumber = expectedSum - actualSum;

            Console.WriteLine("The missing number is: " + missingNumber);
        }

        //5. Write a program that finds the common elements between two arrays.
        public static void FindCommonElements()
        {
            int[] arr1 = CreateArray();
            Console.WriteLine("===================");
            int[] arr2 = CreateArray();

            Console.WriteLine("Common elements:");
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                        break;
                    }
                }
            }
        }

        public static int[] CreateArray()
        {
            Console.WriteLine("Enter the size of an Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element for " + (i + 1) + " position: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe Elements are: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            return arr;
        }

        //1   Write a program that calculates the sum of the digits of a given integer.
        public static void SumOfDigits()
        {
            Console.WriteLine("Enter the Num:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sum += rem;
                n = n / 10;
            }
            Console.WriteLine("The sum is: " + sum);
        }

        //2   Write a program that converts a given decimal number to its binary equivalent.
        public static void ConvertToBinary()
        {
            Console.WriteLine("Enter the Num:");
            int n = Convert.ToInt32(Console.ReadLine());

            string bin = "";
            while (n > 0)
            {
                int rem = n % 2;
                bin = rem+bin;
                n = n / 2;
            }
            Console.WriteLine("The Binary of "+n+" is: "+bin);
        }

        //3   Write a program that generates all permutations of a given string.
        public static void GeneratePermutations(string prefix, string str)
        {
            if(str.Length == 0)
            {
                Console.WriteLine(prefix);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string newPrefix = prefix + str[i];
                    string newStr = str.Substring(0, i) + str.Substring(i + 1);
                    GeneratePermutations(newPrefix, newStr);
                }
            }
        }

        //4   Write a program that removes all vowels from a given string.
        public static void RemoveVowels()
        {
            Console.WriteLine("Enter the String:");
            string str = Console.ReadLine();
            string vowels = "";
            str.ToLower();
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u')
                {
                    vowels = vowels + str[i];
                }
            }

            Console.WriteLine("After Removing Vowels: " + vowels);
        }

        //5   Write a program that calculates the compound interest for a given principal, rate, and time period.
        public static void FindCompoundInterest()
        {
            Console.WriteLine("Enter the Principal: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Time Period: ");
            double t = double.Parse(Console.ReadLine());

            double amount = p*(Math.Pow((1 + r / 100), t));
            Console.WriteLine("The CI: " + (amount-p));
        }

        //1 Write a program that checks if a given string has all unique characters
        public static bool CheckUnique()
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            char[] str1 = str.ToCharArray();
            for(int i = 0; i < str1.Length; i++)
            {
                for(int j = i+1; j < str1.Length; j++)
                {
                    if (str1[i] == str1[j])
                    {
                        return false;
                    }
                }
              
            }
            return true;
        }

        //2 Write a program that generates and prints all prime numbers up to a given number n. 
        public static void PrintPrime(int n)
        {
            for(int i = 2; i <= n; i++)
            {
                if (PrimeCheck(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static bool PrimeCheck(int n)
        {
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //3 Write a program that checks if two given strings are anagrams of each other.
        public static bool CheckAnagrams()
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            if (str1.Length != str2.Length)
            {
                return false;
            }

            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            return new string(charArray1) == new string(charArray2);
        }

        //5 Write a program that reverses the words in a given sentence without changing the order of the words.
        public static void ReverseEachWord()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            string reversedSentence = "";

            foreach (string word in words)
            {
                string reversedWord = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                
                reversedSentence += reversedWord + " ";
            }
            
            reversedSentence.Trim();
            Console.WriteLine("The sentence with reversed words is:");
            Console.WriteLine(reversedSentence);
        }

        //4 Write a program that finds the longest substring in a given string that does not contain any repeating characters. 
        public static void LongestUniqueSubstring()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string longest = string.Empty;
            string current = string.Empty;

            foreach (char c in input)
            {
                if (current.Contains(c))
                {
                    if (current.Length > longest.Length)
                    {
                        longest = current;
                    }

                    int index = current.IndexOf(c);
                    current = current.Substring(index + 1);
                }

                current += c;
            }

            if (current.Length > longest.Length)
            {
                longest = current;
            }

            Console.WriteLine("Longest unique substring: " + longest);
        }

    }
}
