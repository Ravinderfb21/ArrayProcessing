using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProccesing
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is:");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

        public MyFunctionA(string input)
        { //Write a c# program to find the longest word ina string.
            string[] words = input.Split('');

            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];
            int x = 0;

            foreach (var word in words)
            {
                //TODO
            }
            //loop post condition: we now have array wordsLength which
            //contains the lengths of each word

            string currentWord = words[0];
            string nextWord;
            string longestWord = currentWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];

            }
        }

    }
}

