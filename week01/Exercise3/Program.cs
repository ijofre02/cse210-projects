using System;

class Program
{
    static void Main(string[] args)
    {
        // This is the firs part
        //Console.Write("What is the magic number? ");
        //string magicNumberStr = Console.ReadLine();
        //int magicNumber = int.Parse(magicNumberStr);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int gessNumber = -1;

        while (magicNumber != gessNumber)
        {
            Console.Write("What is your gess? ");
            gessNumber = int.Parse(Console.ReadLine()); // all in one line

            if (magicNumber < gessNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > gessNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!!");
            }
        }

    }
}