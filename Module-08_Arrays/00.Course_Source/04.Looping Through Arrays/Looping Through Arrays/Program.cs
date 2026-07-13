Console.WriteLine(":::::::::::::::: Looping Through Arrays ::::::::::::::::");

int[] numbers = { 10, 20, 30, 40, 50 };

// 1. for loop (index-based — most common)

Console.WriteLine("for → ");
for (var index = 0; index < numbers.Length; index++)
{
    Console.Write(" " + numbers[index]);
}


// 2. while loop (manual index control)
Console.WriteLine();
Console.WriteLine("while → ");

int counter = 0;

while (counter < numbers.Length)
{
    Console.Write(" " + numbers[counter]);
    ++counter;
}


// 3. do-while loop (executes at least once)
Console.WriteLine();
Console.WriteLine("do while → ");
int j = 0;

do
{
    Console.Write(" " + numbers[j]);
    ++j;
} while (j < numbers.Length);

// 4. foreach loop (value-based — no index)
Console.WriteLine();
Console.WriteLine("foreach → ");

foreach (var number in numbers)
{
    Console.Write(" " + number);
}