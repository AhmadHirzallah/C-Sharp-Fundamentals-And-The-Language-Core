Console.WriteLine("::::::::::::::::: BASIC :::::::::::::::::::");


int counter = 0;

//! Label => [ labelName: ] statement;
Start:


++counter;

if (counter <= 10)
{
	Console.WriteLine(counter);
	goto Start;
}