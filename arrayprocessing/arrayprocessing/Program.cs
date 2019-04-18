using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprocessing
{
    class Program
    {
        public int[] inputArray = new int[10] { 3, 11, 9, 11, 4, 11, 5, 9, 2, 1 };
        public int[,] frequencyOfOccuranceArray = new int[10, 2];

        static void Main(string[] args) { new Program().Run(); }

        public void Run() { this.InterateOverArray(); }
       
        public void InterateArray()
        {
            int output;
            for (int i = 0; i < inputArray.Length; i++)
            {
                CountFrequencyOfOccurance(inputArray[i]);

            }
        }

        public void CountFrequencyOfOccurance(int inputValue)
        {

            //get a handle on input array
            //find out if inputvalue is in INPUT AARRAY
            for(int i = 0; i < inputArray.Length; i++)
            {
                if(inputArray[i] == inputValue)
                {
                    
                }
            }
        }
        static void Main(string[] args)
        {

            Program a = new Program();

            Console.WriteLine("the longest word is : ");

            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));

            Console.ReadLine();
        }

        public String MyFunctionA(string input)
        {
            string[] words = input.Split(' ');

            int wordArrayLength = words.Length;

            int[] wordsLength = new int[wordArrayLength];

            foreach (var word in words)
            {

            }

            string currentWord = words[0];

            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];

                nextWord = words[y + 1];

            }

            return currentWord;
        }

    }
}