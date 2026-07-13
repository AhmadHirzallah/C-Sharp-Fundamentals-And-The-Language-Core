Console.WriteLine("::::::::::::::::: BASIC :::::::::::::::::::");

for (int i = 1; i <= 10; i++)
{
	if (i == 5)
	{
		Console.WriteLine("!!!!!!!! Skipping [ continue; ] the iteration at i = 5 !!!!!!!!!");
		continue;
	}
	if (i == 7)
	{
		Console.WriteLine("!!!!!!!! Breaking [ break; ] the loop at i = 7 !!!!!!!!");
		break;
	}

	Console.WriteLine($"Current value of i: {i}");
}

Console.WriteLine("Now we are outside the loop because of [break;]");


Console.WriteLine("\n\n\n::::::::::::::::: Daily Budget Tracker :::::::::::::::::::"); //! مراقبة الميزانية

const decimal AllowedBudget = 1000m; //! Initial allowedBudget that i am allowed to spend from
decimal currentspent = 0;

//! [ Min value ]: 5 ( inclusive )
//! [ Max value ]: 100 ( exclusive, so the highest possible [ integer ] it can return is [[ 99 ]] )
//* This means it returns a random integer that is (greater than or equal to [[minValue]]), and (strictly less than [[maxValue]])
while (true)
{
	decimal spentAmountAndMyPurchasesSpending = Random.Shared.Next(5, 100);

	if (currentspent + spentAmountAndMyPurchasesSpending > AllowedBudget)
	{
		Console.WriteLine($"\n!! There is no enough budget left.\nYour current spending is: {currentspent} && \nYour allowed budget is: {AllowedBudget} && \nYour purchase amount is: {spentAmountAndMyPurchasesSpending}\n" +
			$"Problem is if you buy; total spending is: ({currentspent + spentAmountAndMyPurchasesSpending})");
		break;
	}

	Console.WriteLine("\n\nLets Buy Stuffs :) ---------\n");
	Console.WriteLine($"My Current Spending: {currentspent}\n" +
		$"My allowed budget is: {AllowedBudget}" +
		$"\nMy purchase amount is: {spentAmountAndMyPurchasesSpending}");

	currentspent += spentAmountAndMyPurchasesSpending;
	Console.WriteLine($"\nUpdated Current Spending: {currentspent}");
}
