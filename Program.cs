using System;

class Program
{
    static void Main(string[] args)
    {
        ShowMenu();
        GetUserInput();
    }

    static void ShowMenu()
    {
        Console.WriteLine("Welcome to the Fruit shop!");
        Console.WriteLine("Available Fruits: ");
        Console.WriteLine("Apple");
        Console.WriteLine("Mango");
        Console.WriteLine("Banana");
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
        if (lowerName == "apple")
        {
            Console.WriteLine("The price of apple is 70" + symbol);
        }
        else if (lowerName == "mango")
        {
            Console.WriteLine("The price of mango is 50" + symbol);
        }
        else if (lowerName == "banana")
        {
            Console.WriteLine("The price of Banana is 45" + symbol);
        }
        else
        {
            Console.WriteLine("Fruit not available, try again");
        }
    }

}

