using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PrompUserNumber();

        int squeredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squeredNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PrompUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int FavoriteNumber = int.Parse(Console.ReadLine());
        return FavoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the squere of  your number is {square}");
    }
}