Console.WriteLine(":::::::::::::::: Accessing Array Elements ::::::::::::::::");

int[] numbers = [1, 2, 3, 5, 7, 99, 1000];

//! OUTPUT:
//*		1'st: System.Int32[]
//*			- Printing a [Reference Type Variable] will print the [Type Name] of the variable instead of its value.
Console.WriteLine($"1'st: {numbers}");


//! 1) Accessing elements by index

Console.WriteLine($"1'st: {numbers[0]}");

Console.WriteLine($"\n\n[ {numbers[0]} ,{numbers[1]} ,{numbers[2]} ,{numbers[3]} ,{numbers[4]} ,{numbers[5]} ,{numbers[6]} ] ");


//! 2) Modifying element value
numbers[1] = 20;
Console.WriteLine($"\n\n2nd element after I modified it: {numbers[1]}");
