#region Approve Payment - LOGIC (Comparison) & If Statement

Console.WriteLine(":::::::::::::::: Approve Payment :::::::::::::::::\n\n");

decimal ahmadAccountBalance = 500.0m;
decimal invoiceAmount = 300.0m;

if (ahmadAccountBalance >= invoiceAmount)
{
	Console.WriteLine($"Payment approved." +
		$"\nYour current balance: {ahmadAccountBalance:C}" +
		$"\nInvoice amount: {invoiceAmount:C}");

	ahmadAccountBalance -= invoiceAmount;
	Console.WriteLine($"\nPayment Processed Successfully.!\n" +
		$"Ahmad New Balance {ahmadAccountBalance}");
}


#endregion

#region Grant Access - [BOOLEAN] VARIABLE & If Statement


Console.WriteLine("\n\n:::::::::::::::: Grant Access :::::::::::::::::");

bool isEmailVerified = true;

if (isEmailVerified)
{
	Console.WriteLine("Access granted.");
	Console.WriteLine("Redirecting to dashboard...");
	Console.WriteLine("Welcome in Dashboard.");
}


#endregion