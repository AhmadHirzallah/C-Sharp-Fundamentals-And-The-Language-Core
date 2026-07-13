Console.WriteLine(":::::::::::::::: Accessing Array Elements ::::::::::::::::");

int[] numbers = [1, 2, 3, 4, 5, 6];

// 1) Accessing elements by index

Console.WriteLine("1st: " + numbers[0]);
Console.WriteLine("2nd: " + numbers[1]);
Console.WriteLine("3rd: " + numbers[2]);
Console.WriteLine("4th: " + numbers[3]);
Console.WriteLine("5th: " + numbers[4]);
Console.WriteLine("6th: " + numbers[5]);

Console.Write("[ " + numbers[0] + ", " + numbers[1] + ", " + numbers[2] + ", " + numbers[3] + ", " + numbers[4] + ", " + numbers[5] + " ]");
Console.WriteLine();

// 2) Modifying element value

numbers[1] = 20;
Console.WriteLine("2nd: " + numbers[1]);