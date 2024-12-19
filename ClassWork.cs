using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class ClassWork
    {

        public static void SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sum += rem;
                n = n / 10;
            }
            Console.WriteLine("The sum is: " + sum);
        }

        public static void ConvertToBinary(int n)
        {
            string bin = "";
            while (n > 0)
            {
                int rem = n % 2;
                bin = rem+bin;
                n = n / 2;
            }
            Console.WriteLine("The Binary of "+n+" is: "+bin);
        }

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

        public static void RemoveVowels(string str)
        {
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

        public static void FindCompoundInterest(double p, double r, double t)
        {
            double amount = p*(Math.Pow((1 + r / 100), t));
            Console.WriteLine("The CI: " + (amount-p));
        }

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
