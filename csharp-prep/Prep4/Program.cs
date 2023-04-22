using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = 1;
        int total = 0;
        int count = 0;
        int max = -100000;


        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Sum
        foreach (int listNumber in numbers)
        {
            count++;
            total += listNumber;

            if (listNumber > max)
            {
                max = listNumber;
            }
        }
        Console.WriteLine($"The sum is: {total}");

        // Average
        double average = total / count;
        Console.WriteLine($"The average is: {average}");

        // Max
        Console.WriteLine($"The largest number is: {max}");
    }
}