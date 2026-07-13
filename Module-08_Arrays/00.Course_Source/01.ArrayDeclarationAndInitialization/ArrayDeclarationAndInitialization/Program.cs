Console.WriteLine(":::::::::::::::: Declaring and Initializing Arrays ::::::::::::::::");


// 1) Declaration only (no memory allocated yet)

int[] numbers;

// 2) Allocation with fixed length (default values assigned internally)

numbers = new int[5];

// 3) Declaration + allocation in one statement

int[] scores = new int[3];

// 4) Declaration + allocation + initialization (explicit new)

int[] prices = new int[] { 120, 250, 90 };

// 5) Simplified initialization syntax

int[] quantities = { 3, 1, 6, 2 };

// 6) Collection initialization syntax

int[] values = [3, 1, 6, 2];

// 06 using var
var readings = new int[] { 3, 1, 6, 2 };
var tempratures = new[] { 3, 1.6, 6, 2 };
// var digits = [1, 2, 3]; // compile time error