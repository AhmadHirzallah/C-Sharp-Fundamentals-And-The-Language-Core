// Console.WriteLine(":::::::::::::::::: Basic Usage :::::::::::::::::::::::::");

// string word = "METIGATOR";

// foreach (char ch in word)
// {
//     Console.WriteLine(ch);
// }

Console.WriteLine("::::::::::::::::: Password Validator :::::::::::::::::::::::::");

Console.Write("Password: ");

string password = Console.ReadLine();

int upper = 0;
int lower = 0;
int digit = 0;
int symbol = 0;

foreach (char ch in password)
{
    if (char.IsUpper(ch))
    {
        ++upper;
    }
    else if (char.IsLower(ch))
    {
        ++lower;
    }
    else if (char.IsDigit(ch))
    {
        ++digit;
    }
    else
    {
        ++symbol;
    }
}

bool isStrongPassword = upper > 0 && lower > 0 && digit > 0 && symbol > 0 && password.Length >= 8;

if (isStrongPassword)
{
    Console.WriteLine("Strong password. Account created!");
}
else
{
    Console.WriteLine("Weak password. Must have upper, lower, digit and symbol.");
}

