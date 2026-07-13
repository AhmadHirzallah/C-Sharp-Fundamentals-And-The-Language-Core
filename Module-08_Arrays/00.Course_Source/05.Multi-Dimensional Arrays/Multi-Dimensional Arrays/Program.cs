Console.WriteLine(":::::::::::::::: Multi-Dimensional Array ::::::::::::::::");

// 1. Declaration + Allocation
int[,] matrix = new int[2, 3];

// 2. Declaration + Initialization
int[,] grid =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

// Get Length , Rows and Columns

Console.WriteLine("Length: " + grid.Length);
Console.WriteLine("Rows: " + grid.GetLength(0));
Console.WriteLine("Columns: " + grid.GetLength(1));

// 3. Accessing elements
Console.WriteLine("Element [0,0]: " + grid[0, 0]);
Console.WriteLine("Element [1,2]: " + grid[1, 2]);

// 4. Looping through multi-dimensional array

for (int row = 0; row < grid.GetLength(0); row++)
{
    for (int col = 0; col < grid.GetLength(1); col++)
    {
        Console.Write(grid[row, col] + " ");
    }

    Console.WriteLine();
}