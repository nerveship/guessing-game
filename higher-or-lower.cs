using System;

class GuessingGame
{
    static void Main()
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 100);
        int guess = 0;

        Console.WriteLine("Welcome! I have selected a random number between 1-100.\nPlease try to guess which number it is" +
            "and I'll tell you if you're higher or lower than it!");

        while (guess != number)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower!");
            }
        }
        Console.WriteLine($"Congrats! The number was indeed {number}");
        Console.ReadLine();
    }
}