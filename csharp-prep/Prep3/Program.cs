using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        string answer = "Lower";

        while (answer == "Higher" || answer == "Lower")
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);
            
            if (guessNumber > number)
            {
                answer = "Lower";
            }
            else if (guessNumber < number)
            {
                answer = "Higher";
            }
            else
            {
                answer = "You guessed it!";
            }

            Console.WriteLine($"{answer}");
        }
    }
}