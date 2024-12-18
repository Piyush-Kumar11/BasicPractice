using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class ClassWork
    {
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

        public static bool CheckAnagrams(string str1, string str2)
        {
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

        public static string ReverseEachWord(string sentence)
        {
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
            
            return reversedSentence.Trim();
        }

        public static string LongestUniqueSubstring(string input)
        {
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

            return longest;
        }

    }
}
