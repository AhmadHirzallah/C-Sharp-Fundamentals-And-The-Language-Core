// Console.WriteLine(":::::::::::::::::: Basic Usage :::::::::::::::::::::::::");

// int counter = 1;

// do
// {
//     Console.WriteLine(counter);
//     counter++;
// }
// while (counter <= 5);

Console.WriteLine(":::::::::::::::::: Restaurant ordering system :::::::::::::::::::::::::");

decimal total = 0m;
string? choice = "";

string? summary = "";


const decimal BurgerPrice = 8.99m;
const decimal PizzaPrice = 11.49m;
const decimal SaladPrice = 6.99m;


do
{
    Console.WriteLine("\n--- QuickBite Menu ---");

    Console.WriteLine("1. Burger  $" + BurgerPrice);
    Console.WriteLine("2. Pizza   $" + PizzaPrice);
    Console.WriteLine("3. Salad   $" + SaladPrice);
    Console.WriteLine("0. Checkout");

    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            total += BurgerPrice;
            summary += "Burger ......................... $" + BurgerPrice + "\n";
            break;

        case "2":
            total += PizzaPrice;
            summary += "Pizza ......................... $" + PizzaPrice + "\n";
            break;

        case "3":
            total += SaladPrice;
            summary += "Salad ......................... $" + SaladPrice + "\n";
            break;

        default:
            Console.WriteLine("Invalid choice, try again");
            break;
    }


} while (choice != "0");

Console.WriteLine("--------------- BILL SUMMARY ---------------");
Console.WriteLine("Items:");
Console.WriteLine(summary);
Console.WriteLine("--------------------------------------------");
Console.WriteLine($"Final Amount     : ${total}");