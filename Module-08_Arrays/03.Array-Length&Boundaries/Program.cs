Console.WriteLine(":::::::::::::::: Array Length & Boundaries ::::::::::::::::");

int[] numbers = { 10, 20, 30, 40, 50 };

//! 1. Length returns total number of elements
//*		- Length of the Array: 5
Console.WriteLine($"\nLength of the Array: {numbers.Length}");


//! 2. Valid index range is [[0 → Length - 1]]
//* 1'st Element:
Console.WriteLine($"\n\n1'st Element: {numbers[0]}");

//* Last Element:
//*  	[System.IndexOutOfRangeException unhandled]	
//Console.WriteLine($"n\nLast Element: {numbers[numbers.Length]}");

//* Last Element:
Console.WriteLine($"\n\nLast Element -> numbers[5 - 1]: {numbers[5 - 1]}");
Console.WriteLine($"\n\nLast Element -> numbers[4]: {numbers[4]}");
Console.WriteLine($"\n\nLast Element -> numbers[numbers.Length - 1]: {numbers[numbers.Length - 1]}");



//! 3. Invalid access examples (will throw at runtime)
//Console.WriteLine($"{numbers[-1]}"); //? Invalid: Index is negative
//Console.WriteLine($"{numbers[5]}");  //? Invalid: Index is out of bounds