using System;

class Program
{
    static Dictionary<string, int> prices = new Dictionary<string, int>
     {
            {"apple", 50},
            { "mango", 70},
            {"banana", 45}
    };


    static void Main(string[] args)
    {
        ShowMenu();
        GetUserInput();
    }

    static void ShowMenu()
    {
        Console.WriteLine("Welcome to the Fruit shop!");
        Console.WriteLine("Available Fruits: ");
        foreach (var key in prices.Keys)
        {
            Console.WriteLine(key);
        }
    }

    static void GetUserInput()
    {
        while (true)
        {
            Console.Write("What fruit would you like to buy: (type exit to stop program): ");
            String? fruit = Console.ReadLine();
            if (fruit == "exit")
            {
                break;
            }
            else if (fruit != null)
            {
                Price(fruit);
            }
            else
            {
                Console.WriteLine("No fruit entered");
            }
        }
    }

    // Greeting method
    static void Price(string name)
    {
        string lowerName = name.ToLower();
        char symbol = '$';
        if (prices.ContainsKey(lowerName))
        {
            Console.WriteLine("The price of " + name + " is " + prices[lowerName] + symbol);
        }
        else
        {
            Console.WriteLine("That fruit is not available");
        }
    }

}

