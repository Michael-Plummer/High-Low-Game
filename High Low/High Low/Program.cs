using System;

namespace High_Low
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("Welcome to The High Low Game");

            //Create RNG object
            Random RNG = new Random();
            //Choose a random number between 1 and 10
            int number = RNG.Next(1, 11);

            int guess_amount = 0;

            while (true) //Begins the game loop
            {
                //Enter User's guess (Converts string input to integer)
                Console.Write("Please guess the number :  ");
                int guess = Convert.ToInt32(Console.ReadLine());
                guess_amount = (guess_amount + 1);

                //Compare the guess to number
                if (guess < number)
                {
                    Console.WriteLine("Too Low Guess Higher!!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too High Guess Lower!!");
                }
                else
                {
                    Console.WriteLine("You guessed the number correctly congratulations!!");
                    Console.WriteLine("It took you" + guess_amount.ToString + "guesses!");
                    //Console.Write("It took you, ");
                    //Console.Write(guess_amount);
                    //Console.Write(" guesses!");
                    break; //breaks the game loop
                }
            }
            //Press any key
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
