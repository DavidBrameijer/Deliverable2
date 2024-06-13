using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the restocking tool.");

        int sodaStock = 100;
        Console.WriteLine("How many Sodas have been sold today? 100 are in stock");
        int sodaSold = int.Parse(Console.ReadLine());
        int newSoda = sodaStock - sodaSold;

        if (sodaSold > 100)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            Console.WriteLine("There are " + newSoda + " sodas left");
        }

        int chipStock = 40;
        Console.WriteLine("How many Chips have been sold today? 40 are in stock");
        int chipSold = int.Parse(Console.ReadLine());
        int newChip = chipStock - chipSold;

        if (chipSold > 40)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            Console.WriteLine("There are " + newChip + " chips left");
        }

        int candyStock = 60;
        Console.WriteLine("How many Candy has been sold today? 60 are in stock");
        int candySold = int.Parse(Console.ReadLine());
        int newCandy = candyStock - candySold;

        if (candySold > 60)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            Console.WriteLine("There are " + newCandy + " Candy left");
        }

        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

        if (newSoda <= 40)
        {
            Console.WriteLine("Soda needs to be restocked.");
        }

        if (newChip <= 20)
        {
            Console.WriteLine("Chips need to be restocked.");
        }

        if (newCandy <= 40)
        {
            Console.WriteLine("Candy needs to be restocked.");
        }

        Console.WriteLine("Goodbye!");
    }
}