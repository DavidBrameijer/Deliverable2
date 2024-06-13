using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the restocking tool.");

        int sodaStock = 100;
        Console.WriteLine("How many Sodas have been sold today? " + sodaStock + " are in stock");
        int sodaSold = int.Parse(Console.ReadLine());

        if (sodaSold > sodaStock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {

            sodaStock = sodaStock - sodaSold;
            Console.WriteLine("There are " + sodaStock + " sodas left");
        }


        int chipStock = 40;
        Console.WriteLine("How many Chips have been sold today? " + chipStock + " are in stock");
        int chipSold = int.Parse(Console.ReadLine());

        if (chipSold > chipStock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            chipStock = chipStock - chipSold;
            Console.WriteLine("There are " + chipStock + " chips left");
        }


        int candyStock = 60;
        Console.WriteLine("How many Candy has been sold today? " + candyStock + " are in stock");
        int candySold = int.Parse(Console.ReadLine());

        if (candySold > candyStock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            candyStock = candyStock - candySold;
            Console.WriteLine("There are " + candyStock + " Candy left");
        }

        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

        int restockSoda = 40;
        int restockChips = 20;
        int restockCandy = 40;

        if (sodaStock <= restockSoda)
        {
            Console.WriteLine("Soda needs to be restocked.");
        }

        if (chipStock <= restockChips)
        {
            Console.WriteLine("Chips need to be restocked.");
        }

        if (candyStock <= restockCandy)
        {
            Console.WriteLine("Candy needs to be restocked.");
        }

        Console.WriteLine("Goodbye!");
    }
}