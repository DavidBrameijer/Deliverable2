using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Coin Flip Challenge?");
        Console.WriteLine("What is your name?");

        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + " do you want to play the coinflip challenge? Yes or No");

        string answer = Console.ReadLine().ToLower();
        if (answer == "no" || answer == "n")
        {
            Console.WriteLine("You are a coward " + name + "!");
        }

        if (answer == "yes" || answer == "y")
        {
            int plays = 1;
            int wins = 0;
            while (plays <= 5)
            {
                Console.WriteLine("Heads or Tails?");
                string coin = Console.ReadLine().ToLower();

                Random random = new Random();
                var n = random.Next(0, 2);
                // 0 is heads and 1 is tails

                string flipResult;
                if (n == 0)
                {
                    flipResult = "heads";
                }
                else
                {
                    flipResult = "tails";
                }


                if (coin == flipResult)
                {
                    Console.WriteLine("Correct!");
                    //Console.WriteLine(n);
                    //Console.WriteLine(flipResult);
                    wins++;
                    plays++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    //Console.WriteLine(n);
                    //Console.WriteLine(flipResult);
                    plays++;
                }
            }
            Console.WriteLine("Thank you " + name + " you got a score of " + wins + "!");
        }
    }
}