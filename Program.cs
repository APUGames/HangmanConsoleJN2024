using System;
using System.Xml.Linq;

namespace HangTheMan
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GAME 135!");

            string[] words = new string[] { "yearn", "cake", "zip", "blast", "like", "manger" };

            Random rand = new Random();
            int wordSelector = rand.Next(words.Length);

            
            string selectedWord = words[wordSelector];


            foreach (char ch in selectedWord)
            {
                Console.Write("_");
            }

            Console.WriteLine();
            string? lastName = Console.ReadLine();
            Console.WriteLine("Hi " + lastName);
            Console.WriteLine("Welcome to hang man");

            Console.WriteLine("The number of characters to guess is " + selectedWord.Length);

            char[] answerBook = new char[selectedWord.Length];

            for (int answerBookIndex = 0; answerBookIndex < answerBook.Length; answerBookIndex++)
            {
                answerBook[answerBookIndex] = '_';
            }

            int allowedGuess = selectedWord.Length + 5;

            while (true)
            {
                for (int answerBookIndex = 0; answerBookIndex < answerBook.Length; answerBookIndex++)
                {
                    Console.Write(answerBook[answerBookIndex]);
                }
                Console.WriteLine();
                string? playerInput = Console.ReadLine();

                if (playerInput != null && selectedWord.Contains(playerInput[0]))
                {
                    Console.WriteLine("Correct!");

                    int currentIndex = selectedWord.IndexOf(playerInput[0]);
                    answerBook[currentIndex] = playerInput[0];
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                if (Array.IndexOf(answerBook, '_') != -1)
                {
                    Console.WriteLine("win");
                    break;
                }
                if (answerBook.Contains('_') == false)
                {
                    Console.WriteLine("You get to live");
                    break;
                }
            }
        }
    }
}
