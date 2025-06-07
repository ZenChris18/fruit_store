using System;

class Program
{
    static Dictionary<string, int> prices = new Dictionary<string, int>
     {
        {"apple", 50},
        {"mango", 70},
        {"banana", 45},
        {"berry", 30}
    };

    static Dictionary<string, int> cart = new Dictionary<string, int>
     {

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
            Console.WriteLine("Type cart to see your cart");
            Console.Write("What fruit would you like to buy: (type exit to stop program): ");
            String? fruit = Console.ReadLine();
            if (fruit == "exit")
            {
                break;
            }
            else if (fruit == "cart")
            {
                int price = 0;

                foreach (var item in cart)
                {
                    Console.WriteLine(item.Key + " - " + item.Value);
                }
                foreach( var item in cart)
                {
                    price += prices[item.Key] * item.Value;
                }
                Console.WriteLine("Total price: " + price + "$");
            }
            else if (fruit != null && prices.ContainsKey(fruit.ToLower()))
            {
                if (cart.ContainsKey(fruit.ToLower()))
                {
                    cart[fruit.ToLower()] += 1;
                }
                else
                {
                    cart.Add(fruit.ToLower(), 1);
                    Console.WriteLine("you added " + fruit + " to your cart");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid fruit name or type 'cart' to view your cart.");
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

