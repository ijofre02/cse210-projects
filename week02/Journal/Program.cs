using System;
using System.Reflection.Emit;
using Microsoft.VisualBasic;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator randPrompt = new PromptGenerator(); // Create an object to access to GetRandomPrompt

        int userChoise = -1;
        while (userChoise != 5)
        {
            Console.WriteLine("Welcome to Your personal Journale Programa!.");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("Please, select one of the followin choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4.  Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("");
            Console.Write("Your Choise... ");
            userChoise = int.Parse(Console.ReadLine());

            if (userChoise == 1)
            {
                string prompt = randPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
            }

            if (userChoise == 2)
            {

            }

            if (userChoise == 3)
            {

            }

            if (userChoise == 4)
            {
                
            }

            else
            {
                Console.WriteLine("Please select a valid option.");
            }
            

        }



    }
}