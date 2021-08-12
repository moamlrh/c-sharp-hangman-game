using System;
using System.Threading;

class Hangout
{
    static void Main()
    {

        bool isGameOver = false;

        string[] words = { "moaml", "riad", "hussein" };

        int currentWordIndex = 0;
        int numOfTries = words[currentWordIndex].Length * 2;

        string currentGueesChar = "";
        string guessedCharacters = "";
        string word = words[currentWordIndex];

        char[] underScore = new string('-',word.Length).ToCharArray();


        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Clear();
        }

        while (!isGameOver)
        {
            Console.Clear();
            Console.WriteLine($"Guess the word : {new String(underScore)}");
            Console.WriteLine($"Guessed Characters : {guessedCharacters}");
            Console.WriteLine($"You have {numOfTries} tries left.");

            Console.WriteLine();
            Console.Write("Enter you char gusse : ");
            currentGueesChar = Console.ReadLine().ToString();
            guessedCharacters += currentGueesChar + ", ";

            if (word.Contains(currentGueesChar))
            {
                for (int i = 0; i < underScore.Length; i++)
                {
                    if (!(new String(underScore).Contains('-')))
                    {
                        Console.Clear();
                        Console.WriteLine("You'r win.....");
                        isGameOver = true;
                    }
                    else if (word[i] == Convert.ToChar(currentGueesChar))
                    {
                        underScore[i] = Convert.ToChar(currentGueesChar);
                    }
                }
            }

            numOfTries--;
            if (numOfTries == 0)
            {
                isGameOver = true;
                Console.Clear();
                Console.WriteLine("Game is over ....");
            }

        }

    }
}