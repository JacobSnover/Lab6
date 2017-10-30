using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                //prompt for word
                Console.Write("enter word: ");
                string input = Console.ReadLine();
                while (true)
                {
                    if (int.TryParse(input, out int nums) || input == " " || input.Contains('@'))
                    {
                        Console.WriteLine("wrong");
                        Console.Write("enter word: ");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }

                //convert to lower before translating
                var data = input.ToLower();
                string result = "";

                //Translates to pig latin
                for (int i = 0; i < data.Length - 1; i++)
                {
                    char letter = data[i];
                    if (isVowel(letter))
                    {
                        if (i == 0)
                        {
                            result = input + "w";
                            break;
                        }
                        var afterVowel = input.Substring(i);
                        var beforeVowel = input.Substring(0, i);

                        result = afterVowel.Trim() + beforeVowel.Trim();
                        break;
                    }
                }

                //starts with vowel add way to end
                //starts with consonant move all consonants before vowel to end, and add ay
                Console.WriteLine(result + "ay");
                Console.WriteLine(Continue());

            } while (true);

        }

        //check for vowel
        private static bool isVowel(char letter)
        {
            return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
        }

        //translate another word
        public static string Continue()
        {
            while (true)
            {
                Console.Write("Do you want to translate another word? Yes or No: ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "Sounds good. ";
                }
                else if (test == "n" || test == "no")
                {
                    Console.WriteLine("Bye");
                    Console.ReadLine();
                    Environment.Exit(1);
                }

            }
        }
    }
}
