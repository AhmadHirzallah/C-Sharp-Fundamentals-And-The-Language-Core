Console.WriteLine(":::::::::::::::: Declaring and Initializing Arrays ::::::::::::::::");




//! 1) Declaration only (no memory allocated yet)
int[] numbers; //* Any Number is an integer => array [numbers] is an array of type integer.




//! 2) Allocation with fixed length (default values assigned internally)
//* Default Value of integer is 0 => array [numbers] is an array of type integer with 5 elements, all initialized to 0.
numbers = new int[5];




//! 3) Declaration + allocation in one statement
int[] scores = new int[3];



//! 4) Declaration + allocation + initialization (explicit new)
int[] prices = new int[] { 120, 483, 123 };



//! 5) Simplified initialization syntax
//* Without using the 'new' keyword, we can directly assign values to the array during declaration.
//? Just Give:
//	? (1). Type: int[]  =>
//	? (2). Identifier: quantities  =>
//	? (3). values: { 3, 1, 6, 2 }
//	? AS:
int[] quantities = { 3, 1, 6, 2 };


//! 6) Collection initialization syntax
//* Using square brackets [] instead of curly braces {} for initialization.
int[] values = [3, 1, 7, 8, 10, 123, 5681];


//! 7) using [var] keyword => Notice examples that compiler will infer the type of the array based on the assigned values.
//* Type : int[]
var reading = new int[] { 3, 1, 6, 8, 1023 };

//*  Type : double[]
var temperatures = new[] { 3, 1.6, 6, 2 };

//* Type : float[]
var temperaturesFloat = new[] { 3, 1.6f, 6, 2 };

//* Compile time error
//!  🌟🌟 This will result in a [[compile-time error]] because the compiler cannot infer the type of the [[array]] from the [[collection]] initialization syntax without explicit type information.
//var digits = [1, 2, 3];
