using System;
using System.Reflection.Emit;
using Microsoft.VisualBasic;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator randPrompt = new PromptGenerator(); // Create an object to access to GetRandomPrompt
        Journal myJournal = new Journal();


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


                Entry newEntry = new Entry();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._date = DateTime.Now.ToShortDateString();

                myJournal.AddEntry(newEntry);
            }

            if (userChoise == 2)
            {
                myJournal.DisplayAll();
            }

            if (userChoise == 3)
            {
                Console.Write("Enter the file name: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }

            if (userChoise == 4)
            {
                Console.Write("Enter the file name: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            if (userChoise == 5)
            {
                break;
            }

            else
            {
                Console.WriteLine("Please select a valid option.");
            }
            

        }



    }
}