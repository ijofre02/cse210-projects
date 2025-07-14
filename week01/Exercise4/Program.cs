using System;
using System.Diagnostics.Tracing;
using Microsoft.VisualBasic;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a listof numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            userNumber = float.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        float total = 0;
        float larguestNumber = 0;
        float smallerPositiveNumber = float.PositiveInfinity; // infinite positive value
        foreach (float number in numbers)
        {
            total += number;
            if (larguestNumber < number)
            {
                larguestNumber = number;
            }
            if (number < smallerPositiveNumber && number > 0)
            {
                smallerPositiveNumber = number;
            }
        }

        float x = numbers.Count;
        float averangeList = total / x;

        Console.WriteLine($"The Sum is: {total}");
        Console.WriteLine($"The avarange is: {averangeList}");
        Console.WriteLine($"The largest number is: {larguestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallerPositiveNumber}");
    }
}