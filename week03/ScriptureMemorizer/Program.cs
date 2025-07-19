using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Doctrine and Convenants", 1, 37, 38);

        string text = "Search these commandments, for they are true and faithful, and the prophecies and promises " +
                       "which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse " +
                       "not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall " +
                       "all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same.";

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");

        while (scripture.IsCompletelyHidden() == false)
        {
            string input = Console.ReadLine(); // here is wating the ENTER
            if (input.ToLower() == "quit")
            {
                break;
            }

        scripture.HideRandomWords(3);
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        }

    }


}