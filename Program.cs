using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What Fruit do you want to buy?: ");
        string? fruit = Console.ReadLine();
        if (fruit != null)
        {
            Price(fruit);
        }
        else
        {
            Console.WriteLine("No fruit entered");
        }
    }

    // Greeting method
    static void Price(string name)
    {
        char symbol = '$';
        if (name == "Apple")
        {
            Console.WriteLine("The price of apple is 70" + symbol);
        }
        else if (name == "Mango")
        {
            Console.WriteLine("The price of mango is 50" + symbol);
        }
        else
        {
            Console.WriteLine("Fruit not available, try again");
        }
    }

}

