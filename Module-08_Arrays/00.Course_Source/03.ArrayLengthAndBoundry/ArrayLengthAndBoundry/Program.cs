Console.WriteLine(":::::::::::::::: Array Length & Boundaries ::::::::::::::::");

int[] numbers = { 10, 20, 30, 40, 50 };

// 1. Length returns total number of elements

Console.WriteLine("Length: " + numbers.Length);

// 2. Valid index range is 0 → Length - 1

Console.WriteLine("First Element: " + numbers[0]);
Console.WriteLine("Last Element: " + numbers[4]);
Console.WriteLine("Last Element: " + numbers[numbers.Length - 1]);

// 3. Invalid access examples (will throw at runtime)
// Console.WriteLine(numbers[5]); // IndexOutOfRangeException
// Console.WriteLine(numbers[-1]); // IndexOutOfRangeException