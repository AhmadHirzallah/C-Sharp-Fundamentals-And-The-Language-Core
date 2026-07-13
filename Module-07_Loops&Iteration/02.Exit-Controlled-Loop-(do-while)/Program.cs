Console.WriteLine("::::::::::::::::: BASIC :::::::::::::::::::");

int counter = 1;

do
{
	Console.WriteLine($"Counter: {counter}");
	counter++;
}
//while (true); //! Infinit
while (counter <= 10);



Console.WriteLine("\n\n\n::::::::::::::::: Resturant Ordering System :::::::::::::::::::");

decimal totalOrderMoney = 0m;
string? choice = string.Empty;
string? summary = string.Empty;

const decimal BurgerPrice = 5.99m;
const decimal PizzaPrice = 11.49m;
const decimal SaladPrice = 6.99m;

do
{
	Console.WriteLine("\n ----- QuickBite Menu -----\n\n" +
		$"1. Burger Price: {BurgerPrice:C}\n" +
		$"2. Pizza Price: {PizzaPrice:C}\n" +
		$"3. Salad Price: {SaladPrice:C}\n" +
		$"0. Checkout");

	Console.Write("\nPlease choose an option: ");
	choice = Console.ReadLine()!;
	if (!"1230".Contains(choice))
	{
		Console.WriteLine("Wrong Choice; Please select 1, 2, 3, or 0.");
		continue;
	}

	if (choice != null && choice != "0")
	{
		// Advanced switch expression with tuple: returns (price, itemName)
		var (price, itemName) = choice switch
		{
			"1" => (BurgerPrice, "Burger"),
			"2" => (PizzaPrice, "Pizza"),
			"3" => (SaladPrice, "Salad"),
			_ => (0m, "Invalid choice")
		};

		// Add price to total and append to summary
		totalOrderMoney += price;
		summary += price > 0 ? $"\n  • {itemName}: {price:C}" : string.Empty;

		// Provide user feedback
		if (price > 0)
			Console.WriteLine($"✓ Added {itemName} ({price:C}) to your order");
		else
			Console.WriteLine("✗ Invalid choice. Please select 1, 2, 3, or 0.");
	}
} while (choice != "0");

// Display final summary
Console.WriteLine("\n\n ═══════════════════════════════════════");
Console.WriteLine(" ORDER SUMMARY");
Console.WriteLine(" ═══════════════════════════════════════");
Console.WriteLine(summary);
Console.WriteLine($"\n Total: {totalOrderMoney:C}");
Console.WriteLine(" ═══════════════════════════════════════");
