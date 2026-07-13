Console.WriteLine(":::::::::::::::: Multi-Dimensional Array ::::::::::::::::");

//! 1. Declaration + Allocation
int[,] matrix2D = new int[2, 3];
int[,,] matrix3D = new int[2, 3, 4];


{
	//! 2. Declaration + Initialization

	int[,] grid =
	{
		{1, 8, 1, 3},
		{1, 4, 8, 9}
	};

	//! Length: 8 => 2 rows * 4 columns = 8 elements
	Console.WriteLine($"Length: {grid.Length}");
	Console.WriteLine($"Rows: {grid.GetLength(0)}");
	Console.WriteLine($"Columns: {grid.GetLength(1)}");

	int[,,] matrix3Dimensions = new int[2, 3, 4];
	Console.WriteLine($"\n\n\n3D Matrix: int[,,] matrix3Dimensions = new int[2, 3, 4];\n" +
		$"Length: {matrix3Dimensions.Length}\n" +
		$"Dimensions: {matrix3Dimensions.GetLength(0)}, {matrix3Dimensions.GetLength(1)}, {matrix3Dimensions.GetLength(2)} ");



	//! ERRORS
	//? ERROR: An array initializer of length '8' is expected
	//int[,] grid =
	//{
	//	{1, 8, 1, 3, 1 , 5 , 99 ,99 },
	//	{1 , 4 , 8 , 9 }
	//};

	//? ERROR: An array initializer of length '4' is expected
	//int[,] grid2 =
	//{
	//	{1 , 4 , 8 , 9 },
	//	{1, 8, 1, 3, 1 , 5 , 99 ,99 }
	//};

}



{
	//! 3. Accessing elements
	int[,] grid =
	{
		{1, 8, 1, 3},
		{1, 4, 8, 9}
	};

	Console.WriteLine("\n\n\nAccessing Elements:");
	Console.WriteLine($"Element at [0,0]: {grid[0, 0]}");
	Console.WriteLine($"Element at [0,1]: {grid[0, 1]}");
	Console.WriteLine($"Element at [1,2]: {grid[1, 2]}");
	Console.WriteLine($"Element at [1,3]: {grid[1, 3]}");
}

{
	//! 4. Looping through multi-dimensional array
	Console.WriteLine("\n\n\nLooping through Elements:");
	int[,] grid =
	{
		{1, 8, 1, 3},
		{1, 4, 8, 9}
	};

	for (int row = 0; row < grid.GetLength(0); row++)
	{
		Console.WriteLine($"Row Index {row}");
		for (int col = 0; col < grid.GetLength(1); col++)
		{
			Console.WriteLine($"Element at [{row},{col}]: {grid[row, col]}");
		}
		Console.WriteLine();
	}

}