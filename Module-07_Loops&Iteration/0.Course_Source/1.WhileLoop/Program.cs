Console.WriteLine(":::::::::::::::::: Basic Usage :::::::::::::::::::::::::");

int number = 1;

while (number <= 5)
{
    Console.WriteLine(number);
    number++;
}

Console.WriteLine(":::::::::::::::::: ATM PIN Validation :::::::::::::::::::::::::");

string correctPin = "1234";
int maxAttempts = 3;
int attempts = 0;

Console.Write("Enter PIN: ");

string? pin = Console.ReadLine();

while (pin != correctPin && attempts < maxAttempts)
{
    attempts++;

    int remaining = maxAttempts - attempts;

    if (remaining > 0)
    {
        Console.WriteLine("Wrong Pin Attemps left: " + remaining);
        Console.Write("Enter PIN: ");
        pin = Console.ReadLine();
    }
}

if (pin == correctPin)
{
    Console.WriteLine("Access granted, Welcome!");
}
else
{
    Console.WriteLine("Card blocked. visit your nearest branch!.");
}