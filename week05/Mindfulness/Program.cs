using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        while (userChoice != 4)
        {

        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();

        Console.WriteLine(" Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listening activity");
        Console.WriteLine(" 4.Quit");
        Console.Write("Select a choice from the menu: ");
        userChoice = int.Parse(Console.ReadLine());


        if (userChoice == 1)
        {
            Console.Clear();
            BreathingActivity activity = new BreathingActivity();
            activity.Run();
        }

        if (userChoice == 2)
        {
            Console.Clear();
            ReflectingActivity activity = new ReflectingActivity();
            activity.Run();
        }

        if (userChoice == 3)
        {
            Console.Clear();
            ListingActivity activity = new ListingActivity();
            activity.Run();
        }
        }


    }
}