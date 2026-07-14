{
	Console.WriteLine("\nNot Organized Approach:");
	var sodaPrice = 2.99m;
	var sodaQuantity = 3;
	var totalSodaCost = sodaPrice * sodaQuantity;

	var chipsPrice = 1.49m;
	var chipsQuantity = 2;
	var totalChipsCost = chipsPrice * chipsQuantity;

	Console.WriteLine($"Total cost for sodas: ${totalSodaCost:F2}");
	Console.WriteLine($"Total cost for chips: ${totalChipsCost:F2}");
}

{

	Console.WriteLine("\n\n==================\n" +
		"Organized Approach using methods:");
	var sodaPrice = 2.99m;
	var sodaQuantity = 3;

	var chipsPrice = 1.49m;
	var chipsQuantity = 2;

	Console.WriteLine($"Total cost for sodas: ${CalculateTotalCost(sodaPrice, sodaQuantity):F2}");
	Console.WriteLine($"Total cost for chips: ${CalculateTotalCost(chipsPrice, chipsQuantity):F2}");

	decimal CalculateTotalCost(decimal price, int quantity)
	{
		return price * quantity;
	}

}

{
	var price = 2.99m;
	var taxRate = 0.07m;

	decimal totalTax = price * taxRate;
	decimal totalPrics = price + totalTax;

	Console.WriteLine("\n\n\n" +
		"==============================\n\n" +
		"Not organized; no methods:\n" +
		$"Total Price with Tax: {totalPrics:F2}");
}

{
	var price = 2.99m;
	var taxRate = 0.07m;

	decimal totalPrics = CalculateFinalPrice(price, taxRate);

	Console.WriteLine("\n\n\n" +
		"==============================\n\n" +
		$"Methods Professional Approach:\nTotal Price with Tax: {totalPrics:F2}");

	decimal CalculateFinalPrice(decimal price, decimal taxRate)
	{
		decimal totalTax = CalculateTaxPrice(price, taxRate);

		decimal finalPrice = totalTax + price;

		return finalPrice;
	}

	decimal CalculateTaxPrice(decimal price, decimal taxRate)
	{
		return price * taxRate;
	}
}
