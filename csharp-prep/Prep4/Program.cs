using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (Enter 0 to quit): ");
            
            string userEntry = Console.ReadLine();
            
            userNumber = int.Parse(userEntry);
            
            // Adds number to list, if number isn't 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //  part 1 Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: calculate average
       
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}