Console.WriteLine("::::::::::::::::: BASIC :::::::::::::::::::");


//! Grid System like X/O Game

for (int row = 1; row <= 3; row++)
{
	for (int column = 1; column <= 3; column++)
	{
		Console.Write($"({row},{column})");
	}
	Console.WriteLine();
}



Console.WriteLine("\n\n\n::::::::::::::::: Clinic Weekly Slot Generator :::::::::::::::::::");

Console.WriteLine("\nOpen: 9:00 AM - 5:00 PM (17:00) | Slot Duration: 30 minutes");

for (int day = 1; day <= 7; day++)
{
	Console.WriteLine($"\n ====== Day #{day} =>");

	//! I will close at 5PM (17:00); so 16 is the last hour that i will start a slot at, because the slot duration is 30 minutes, so the last slot will be from 16:00 to 16:30
	for (int hour = 9; hour <= 16; hour++)
	{
		Console.WriteLine($"{hour}:00-{hour}:30");
		Console.WriteLine($"{hour}:30-{hour + 1}:00");
	}
}
