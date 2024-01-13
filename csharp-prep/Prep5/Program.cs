using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); 


        string username = PromptUserName(); 

        int favNum = PromptUserNumber(); 

        int square = SquareNumber(favNum); 

        

        DisplayResult(username, square); 
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your username (as a string): ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareNumber(int value)
    {
        return value * value;
    }

    static void DisplayResult(string usersName, int square)
    {
        Console.WriteLine($"{usersName}, the square of your number is {square}");
    }
}
