using System;
using System.IO.Compression;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        /*
        /// read and write lines
        Console.WriteLine("Hello Sandbox World!");

        Console.Write("What is your first name? : ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? : ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
*/
        ///////////////////////////////////////////////////////////////////////////////
        /// Grade letters
        /*
                Console.WriteLine("What is your grade percentage? ");
                string userInputText = Console.ReadLine();
                int grade = int.Parse(userInputText);
                string gradeLet = "A";
                string gradeSign = "=";

                if (grade >= 90)
                {
                    gradeLet = "A";
                }
                else if (grade >= 80)
                {
                    gradeLet = "B";
                }
                else if (grade >= 70)
                {
                    gradeLet = "C";
                }
                else if (grade >= 60)
                {
                    gradeLet = "D";
                }
                else
                {
                    gradeLet = "F";
                }

                if (grade % 10 >= 7)
                {
                    gradeSign = "+";
                }
                if (grade % 10 <= 3)
                {
                    gradeSign = "-";
                }

                if (gradeLet == "A" && gradeSign == "+" || gradeLet == "F")
                {
                    gradeSign = "";
                }

                Console.WriteLine($"{gradeLet}{gradeSign}");

                if (grade > 70)
                {
                    Console.WriteLine("Congrats! You pass!");
                }
                else
                {
                    Console.WriteLine("lmao loser\n...\nI mean, you'll get 'em next time!");
                }

                */
        ///////////////////////////////////////////////////////////////////////////////
        /* 
        /// number guesser

        while (true)
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 11);
            int tally = 0;

            while (true)
            {
                Console.Write("What is your guess? :");
                string userGuess = Console.ReadLine();
                int numGuess = int.Parse(userGuess);
                tally += 1;

                if (numGuess == magicNum)
                {
                    Console.WriteLine($"you win! It took you {tally} guesses!");
                    break;
                }
                else
                {
                    if (numGuess > magicNum)
                    {
                        Console.WriteLine("Lower");
                    }
                    if (numGuess < magicNum)
                    {
                        Console.WriteLine("Higher");
                    }

                }
            }

            Console.WriteLine("Would you like to play again? (y/n) ");
            string playAgain = Console.ReadLine();

            if (playAgain != "y")
            {
                break;
            }
        }
        */

        ///////////////////////////////////////////////////////////////////////////////
        /// list appendages

        List<int> numbers = new List<int>();

        Console.WriteLine("Write a list of numbers, type 0 when done.");
        int sum = 0;

        while (true)
        {
            Console.Write(":: ");
            string userInputText = Console.ReadLine();
            int num = int.Parse(userInputText);
            if (num == 0)
            {
                break;
            }
            numbers.Add(num);
        }

        int max = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The max is: {max}");


    }


}