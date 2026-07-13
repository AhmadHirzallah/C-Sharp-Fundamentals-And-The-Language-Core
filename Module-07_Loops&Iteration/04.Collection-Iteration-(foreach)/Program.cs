Console.WriteLine("::::::::::::::::: BASIC :::::::::::::::::::");

const string MyName = "Ahmad Omar Ibrahim Hirzallah";


//! var/char both works
//foreach (var character in MyName)
foreach (char character in MyName)
{
	Console.Write($"{character}");
}
Console.WriteLine("\n\n\n");


//! Print each character in the string MyName on a new line, but if the character is a space, print an empty line instead of the space.
foreach (var character in MyName)
{
	if (character == ' ')
	{
		Console.WriteLine();
		continue;
	}
	Console.Write($"{character}");
}

Console.WriteLine("\n\n\n");


Console.WriteLine("::::::::::::::::: Password Validator :::::::::::::::::::");

//! 1 Captial, 1 Small , 1 Number, 1 Special Character and password length should be at least 8 characters

Console.Write("Password: ");
string password = Console.ReadLine()!;

byte upperCount = 0,
	lowerCount = 0,
	numberCount = 0,
	specialSymbolsCount = 0;

foreach (char ch in password)
{
	if (char.IsUpper(ch))
	{
		++upperCount;
	}
	else if (char.IsLower(ch))
	{
		++lowerCount;
	}
	else if (char.IsDigit(ch))
	{
		++numberCount;
	}
	else
	{
		++specialSymbolsCount;
	}
}

bool isStrongPassword = upperCount > 0 && lowerCount > 0 && numberCount > 0 && specialSymbolsCount > 0 && password.Length >= 8;

if (isStrongPassword)
{
	Console.WriteLine("Strong Password. Account created successfully.");
}
else
{
	Console.WriteLine("Weak Password. Please choose a stronger password.");
}

string refactorPasswordTips = string.Empty;

if (upperCount == 0)
{
	refactorPasswordTips += "Add at least one uppercase letter.\n";
}
if (lowerCount == 0)
{
	refactorPasswordTips += "Add at least one lowercase letter.\n";
}
if (numberCount == 0)
{
	refactorPasswordTips += "Add at least one number.\n";
}
if (specialSymbolsCount == 0)
{
	refactorPasswordTips += "Add at least one special character.\n";
}
if (password.Length < 8)
{
	refactorPasswordTips += "Make sure your password is at least 8 characters long.\n";
}

if (!isStrongPassword)
{
	Console.WriteLine("\n\nRefactor Password Tips:\n" + refactorPasswordTips);
}