// ============================================================
// Exercise 1 — Easy
// ============================================================
{
	Console.WriteLine("Exercise 1 — Easy");
	Console.WriteLine("Problem: Declare an integer array with 4 elements: 10, 20, 30, 40. Print the first and last elements.");
	Console.WriteLine("Expected Output:");

	int[] numbers = { 10, 20, 30, 40 };
	Console.WriteLine(numbers[0]);
	Console.WriteLine(numbers[numbers.Length - 1]);
}

Console.WriteLine();

// ============================================================
// Exercise 2 — Easy
// ============================================================
{
	Console.WriteLine("Exercise 2 — Easy");
	Console.WriteLine("Problem: Create a string array of 3 fruit names. Use a foreach loop to print each fruit on its own line.");
	Console.WriteLine("Expected Output:");

	string[] fruits = { "Apple", "Banana", "Cherry" };
	foreach (string fruit in fruits)
	{
		Console.WriteLine(fruit);
	}
}

Console.WriteLine();

// ============================================================
// Exercise 3 — Medium
// ============================================================
{
	Console.WriteLine("Exercise 3 — Medium");
	Console.WriteLine("Problem: Declare an integer array { 3, 7, 2, 9, 5 }. Use a for loop to find and print the largest number.");
	Console.WriteLine("Expected Output:");

	int[] numbers = { 3, 7, 2, 9, 5 };
	int largest = numbers[0];
	for (int i = 1; i < numbers.Length; i++)
	{
		if (numbers[i] > largest)
		{
			largest = numbers[i];
		}
	}
	Console.WriteLine(largest);
}

Console.WriteLine();

// ============================================================
// Exercise 4 — Medium
// ============================================================
{
	Console.WriteLine("Exercise 4 — Medium");
	Console.WriteLine("Problem: Create an integer array { 4, 8, 15, 16, 23 }. Use a loop to calculate and print the sum of all elements.");
	Console.WriteLine("Expected Output:");

	int[] numbers = { 4, 8, 15, 16, 23 };
	int sum = 0;
	foreach (int n in numbers)
	{
		sum += n;
	}
	Console.WriteLine(sum);
}

Console.WriteLine();

// ============================================================
// Exercise 5 — Medium
// ============================================================
{
	Console.WriteLine("Exercise 5 — Medium");
	Console.WriteLine("Problem: Declare a 2D integer array representing a 2x3 grid:");
	Console.WriteLine("1 2 3");
	Console.WriteLine("4 5 6");
	Console.WriteLine("Print all elements row by row, each on the same line separated by a space, and each row on a new line.");
	Console.WriteLine("Expected Output:");

	int[,] grid = { { 1, 2, 3 }, { 4, 5, 6 } };
	//for (int row = 0; row < 2; row++)
	for (int row = 0; row < grid.GetLength(0); row++)
	{
		//for (int col = 0; col < 3; col++)
		for (int col = 0; col < grid.GetLength(1); col++)
		{
			Console.Write(grid[row, col]);
			if (col < 2)
				Console.Write(" ");
		}
		Console.WriteLine();
	}
}

Console.WriteLine();

// ============================================================
// Exercise 6 — Hard
// ============================================================
{
	Console.WriteLine("Exercise 6 — Hard");
	Console.WriteLine("Problem: You are building an annual sales report. Declare an integer array of 12 monthly sales figures:");
	Console.WriteLine("{ 1200, 1500, 1100, 1800, 2100, 1950, 2300, 2400, 2050, 1750, 1600, 2200 }");
	Console.WriteLine("Calculate and print:");
	Console.WriteLine("1. The total annual sales");
	Console.WriteLine("2. The average monthly sales (as a double)");
	Console.WriteLine("3. The best (highest) month number (1-based index)");
	Console.WriteLine("Expected Output:");

	int[] sales = { 1200, 1500, 1100, 1800, 2100, 1950, 2300, 2400, 2050, 1750, 1600, 2200 };
	int totalAnnualSales = 0;
	int bestMonthNumber = 1;
	int highestMonthSaleRecord = sales[0];
	for (int i = 0; i < sales.Length; i++)
	{
		totalAnnualSales += sales[i];
		if (sales[i] > highestMonthSaleRecord)
		{
			highestMonthSaleRecord = sales[i];
			bestMonthNumber = i + 1;
		}
	}
	double average = (double)totalAnnualSales / sales.Length;
	Console.WriteLine("sales array length [sales.Length]: " + sales.Length);
	Console.WriteLine($"Total: {totalAnnualSales:C}");
	Console.WriteLine($"Average: {average:F3}");
	Console.WriteLine($"Best Month: {bestMonthNumber}");
}
