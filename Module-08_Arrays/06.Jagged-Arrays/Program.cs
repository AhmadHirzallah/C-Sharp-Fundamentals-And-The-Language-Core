Console.WriteLine(":::::::::::::::: Jagged Array ::::::::::::::::");

//! 1. Declaration (array of arrays)
int[][] jagged = new int[2][]; //! This is an Array of Arrays; No allocations


//! 2. Allocate each inner array separately
jagged[0] = new int[3];
jagged[1] = new int[2];

Console.WriteLine($"Jagged Array Rows Number: {jagged.Length}");
Console.WriteLine($"Columns in Row 0: {jagged[0].Length}");
Console.WriteLine($"Columns in Row 1: {jagged[1].Length}");


//! 3. Initialization shortcut
int[][] data =
{
	new int[] { 1, 2, 3, 4, 5, 6 },
	new int[] { 4, 5 }
};

Console.WriteLine($"\n\n\r\nInitialization shortcut:\n" +
	$"Jagged Array Length: {data.Length}");
Console.WriteLine($"Columns in Row 0 (Row[0].Length): {data[0].Length}");
Console.WriteLine($"Columns in Row 1 (Row[1].Length): {data[1].Length}");


//! 4. Looping through jagged array


Console.WriteLine("\n\n\r\nLooping through jagged array:");
for (int row = 0; row < data.Length; row++)
{
	Console.WriteLine($"Row {row}:");
	for (int col = 0; col < data[row].Length; col++)
	{
		Console.Write($"[{data[row][col]}] ");
	}
	Console.WriteLine("\n");
}