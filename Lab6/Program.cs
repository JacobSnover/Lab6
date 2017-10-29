﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        public List<string> wordSplits = new List<string>();
        static void Main(string[] args)
        {            //string vowel = ("aeiou");
            //prompt for word
            //Translates to pig latin
            //convert to lower before translating
            //starts with vowel add way to end
            //starts with consonant move all consonants before vowel to end, and add ay
            //translate another word
            Console.Write("enter word: ");
            string input = Console.ReadLine().ToLower();
           
            char[] splits = new char[0];
            while (true)
            {
                if (!int.TryParse(input, out int nums))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("wrong");
                    Console.Write("enter word: ");
                    input = Console.ReadLine().ToLower();
                }
            }
            int c = 0;
            string result = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                char letter = input[i];
                if (isVowel(letter))
                {
                    if (i == 0)
                    {
                        result = input + "w";
                        break;
                    }
                    var afterVowel = input.Substring(i);
                    var beforeVowel = input.Substring(0, i);
                    result = afterVowel + beforeVowel;
                }

               
            }

            Console.WriteLine(result + "ay");

        }

        private static bool isVowel(char letter)
        {
            return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
        }
    }
}
