using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Sandbox World!");

        Console.Write("What is your first name? : ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? : ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
*/

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

        
    }
}