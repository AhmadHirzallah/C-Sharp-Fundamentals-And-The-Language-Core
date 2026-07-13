Console.WriteLine(":::::::::::::::: Jagged Array ::::::::::::::::");

// 1. Declaration (array of arrays)
int[][] jagged = new int[2][];


// 2. Allocate each inner array separately
jagged[0] = new int[3];
jagged[1] = new int[2];

Console.WriteLine("Rows: " + jagged.Length);
Console.WriteLine("Columns in row 0: " + jagged[0].Length);
Console.WriteLine("Columns in row 1: " + jagged[1].Length);

// 3. Initialization shortcut
int[][] data =
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 5 }
};


Console.WriteLine("Rows: " + data.Length);
Console.WriteLine("Row 0 length: " + data[0].Length);
Console.WriteLine("Row 1 length: " + data[1].Length);


// 5. Looping through jagged array
for (int row = 0; row < data.Length; row++)
{
    for (int col = 0; col < data[row].Length; col++)
    {
        Console.Write(data[row][col] + " ");
    }

    Console.WriteLine();
}