Console.WriteLine("\n\n=================== Use a for loop to print the numbers 1 through 5, one per line ==============\n");

for (int number = 1; number <= 5; number++)
{
	Console.WriteLine(number);
}


Console.WriteLine("\n\n=================== Use a while loop to print all even numbers from 2 to 10 ==============\n");

byte evenNumber = 2;

do
{
	if (evenNumber % 2 == 0)
	{
		Console.WriteLine(evenNumber);
	}

	++evenNumber;
}
while (evenNumber <= 10);


Console.WriteLine("\n\n=================== [More Clever] Use a while loop to print all even numbers from 2 to 10 ==============\n");
byte evenNumber2 = 2;

do
{

	Console.WriteLine(evenNumber2);

	evenNumber2 += 2;
}
while (evenNumber2 <= 10);



Console.WriteLine("\n\n=================== \n\nUse a do-while loop that starts at count = 1 and keeps printing count while it is less than or equal to 3.\nThe loop body must always run at least onces: \n");

int count = 1;
do
{
	Console.WriteLine(count);
	count++;
} while (count <= 3);



Console.WriteLine("\n\n=================== \n\nUse a for loop to print numbers from 1 to 10. Use continue to skip the number 5, and use break to\r\nstop the loop when the number reaches 8.: \n");

for (int i = 1; i <= 10; i++)
{
	if (i == 5)
		continue;
	if (i == 8)
		break;
	Console.WriteLine(i);
}

Console.WriteLine("\n\n=================== \n\nUse a nested loop to print a multiplication table for numbers 1 to 3 (rows) by 1 to 3 (columns). Format\r\neach result as \"A x B = C\".: \n");


for (int row = 1; row <= 3; row++)
{
	for (int col = 1; col <= 3; col++)
	{
		Console.WriteLine($"{row} * {col} = {row * col}");
	}

}


Console.WriteLine("\n\n=================== \n\nUse a [[for loop]] to sum all integers from 1 to 100. Print the total. Think carefully: do you need a\r\nseparate variable to accumulate the sum?: \n");

int summation = 0;
for (int number = 1; number <= 100; number++)
{
	Console.WriteLine($"Currently Adding: {number}; Current Summation: {summation}");
	summation += number;
}


Console.WriteLine($"\nThe Final Summation of integers from 1 to 100 is: {summation}");