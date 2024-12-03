using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int num;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                num = random.Next(min, max + 1);
                response = "";
                while (guess != num)
                {
                    Console.WriteLine("guess a number between " + min + " - " + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > num)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + num);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);
                Console.Write("Would you like to play again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}