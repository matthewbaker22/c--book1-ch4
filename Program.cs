using System;

namespace ch4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 100);
            Console.WriteLine($"SECRET NUM: {secretNumber}");

            Console.WriteLine("Select your difficulty, easy, medium, or hard");
            string difficulty = Console.ReadLine();

            int numberOfGuesses = 0;
            if(difficulty.ToLower() == "easy") {
                Console.WriteLine("You chose easy mode, you have 8 guesses");
                numberOfGuesses = 7;
            } else if(difficulty.ToLower() == "medium") {
                Console.WriteLine("You chose easy mode, you have 6 guesses");
                numberOfGuesses = 5;
            } else if(difficulty.ToLower() == "hard") {
                Console.WriteLine("You chose easy mode, you have 4 guesses");
                numberOfGuesses = 3;
            } else if(difficulty.ToLower() == "cheater") {
                Console.WriteLine("You chose cheater mode, you have unlimited guesses");
                numberOfGuesses = 999999999;
            }

            Console.WriteLine("Try and guess the secret number..");
            string number = Console.ReadLine();

            int i = 0;
            Boolean correct = false;
            while (i < numberOfGuesses && correct == false) {
                
                if(int.Parse(number) == secretNumber) {
                    Console.WriteLine($"Your guess({number})");
                    Console.WriteLine("Success! You guessed the correct number!");
                    correct = true;
                } else {
                    Console.WriteLine($"Your guess {number} was incorrect, try again.");
                    Console.WriteLine($"You have {numberOfGuesses - i} guesses left.");

                    if(int.Parse(number) < secretNumber) {
                        Console.WriteLine("Guess higher!");
                    } else if (int.Parse(number) > secretNumber) {
                        Console.WriteLine("Guess lower!");
                    }
                    i++; 
                }
                number = Console.ReadLine();
            }    
        }
    }
}
