Console.WriteLine(":::::::::::::::: Approve Payment - {if-else blocks}:::::::::::::::::");

decimal accountBalance = 600m;
decimal invoiceAmount = 700m;

if (accountBalance >= invoiceAmount)
{
	Console.WriteLine($"Payment Approved." +
		$"\nYour current balance: {accountBalance:C}" +
		$"\nInvoice amount: {invoiceAmount:C}");

	accountBalance -= invoiceAmount;
	Console.WriteLine($"\nPayment Processed Successfully.!\n" +
		$"New Balance: {accountBalance:C}");
}
//Console.WriteLine("Compile-Time Error Line; we can't separate [if-else]!\n"); //! Compile-Time Error Line
else
{
	Console.WriteLine($"Payment Denied.\n" +
		$"You are: Poor, destitute, you have no money" +
		$"\nYour current balance: {accountBalance:C}" +
		$"\nInvoice amount: {invoiceAmount:C}");

	Console.WriteLine("\nWe can't process payment due to insufficient account balance.");
}
