Console.WriteLine(":::::::::::::::: Approve Payment :::::::::::::::::");

decimal accountBalance = 500m;
decimal invoiceAmount = 300m;


if (accountBalance >= invoiceAmount)
{
    Console.WriteLine("Payment approved.");
}

Console.WriteLine(":::::::::::::::: Grant Access :::::::::::::::::");

bool isEmailVerified = true;

if (isEmailVerified)
{
    Console.WriteLine("Access granted.");
}