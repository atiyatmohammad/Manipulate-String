using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deal_With_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            string input = "capiTalIze tHe titLe"; // input1
            ConverToWords(input);
             input = "First leTTeR of EACH Word";// input2
            ConverToWords(input);
             input = "i lOve leetcode"; // input3
            ConverToWords(input);
            Console.WriteLine();
            Console.Write("Enter String: ");
             input = Console.ReadLine();
            ConverToWords(input);
            Console.WriteLine();
        }
        static void ConverToWords(string input)
        {
            string[] words = input.ToLower().Split(' '); // we convert string to lower and split  to words by space 

            foreach (var word in words)           // loop thru each word
            {
                               
                if (word.Length > 2)
                {
                    Console.Write($"{ConvertFisrtLetterToUpper(word),-2} "); // call method to convert first letter to capital
                }
                else
                {
                    Console.Write($"{word} ");
                }
            }
            Console.WriteLine();
        }
        static string ConvertFisrtLetterToUpper(string word) 
        {
            // upper first letter then concatenate the first character with the rest of the substring and return value
            return $"{word[0].ToString().ToUpper()}{word.Substring(1)}"; 
            
        }

    }
}
