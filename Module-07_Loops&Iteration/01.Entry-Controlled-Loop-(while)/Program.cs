Console.WriteLine("::::::::::::::::: BASIC :::::::::::::::::::");



int number = 1;

Console.WriteLine(number);
number++;


Console.WriteLine(number);
number++;

Console.WriteLine(number);
number++;



int number2 = 1;

//while (true)
//{
//	Console.WriteLine(number2);
//	number2++;
//}

while (number2 <= 5)
{
	Console.WriteLine(number2);
	number2++;
}




Console.WriteLine("\n\n\n::::::::::::::::: ATM PIN VALIDATION :::::::::::::::::::");

string correctPinOfUser = "1234";
int maxAttempts = 3;
int userCurrentAttempt = 0;

string userInputPin = string.Empty;
//userInputPin = Console.ReadLine()!;

while (userInputPin != correctPinOfUser && userCurrentAttempt < maxAttempts)
{
	Console.Write("\n\nEnter PIN: ");
	userInputPin = Console.ReadLine()!;
	userCurrentAttempt++;
	if (userInputPin == correctPinOfUser)
		break;
	Console.WriteLine($"Attemp {userCurrentAttempt} failed");
	Console.WriteLine($"You just have {maxAttempts - userCurrentAttempt} attempts left.");
}
if (userInputPin == correctPinOfUser)
{
	Console.WriteLine("Congratulations! You have entered the correct PIN.");
}
else
{
	Console.WriteLine("You have exceeded the maximum number of attempts. Please try again later.");
}