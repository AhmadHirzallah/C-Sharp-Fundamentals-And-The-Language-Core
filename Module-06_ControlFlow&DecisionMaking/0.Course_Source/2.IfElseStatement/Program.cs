Console.WriteLine(":::::::::::::::: Approve Payment :::::::::::::::::");

decimal accountBalance = 600m;
decimal invoiceAmount = 700m;

if (accountBalance >= invoiceAmount)
{
    Console.WriteLine("Payment approved.");
}
else
{
    Console.WriteLine("Insufficient balance.");
}