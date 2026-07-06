//! - Let us understand the features of the dynamic keyword in C#:
//*		- It was introduced in C#4.0
//*		- This is dynamically typed.
//*		- There is no need to initialize at the time of declaration.
//*		- Errors are caught at runtime.
//*		- There is no Intellisense support.
//*		- dynamic allows the type of value to change after it is assigned to initially.


//! No need for initialization!
dynamic dynamicResult;

dynamicResult = 1;
Console.WriteLine($"{nameof(dynamicResult)} = {dynamicResult}");

dynamicResult = "Ahmad Hirzallah";
Console.WriteLine($"\n\n{nameof(dynamicResult)} is changed (int -> string)\n" +
					$"{nameof(dynamicResult)} Value: {dynamicResult}");


dynamicResult = 5005425324.123722413137;
Console.WriteLine($"\n\n{nameof(dynamicResult)} is changed (string -> double)\n" +
					$"{nameof(dynamicResult)} Value: {dynamicResult}");

dynamicResult = 500.72137F;
Console.WriteLine($"\n\n{nameof(dynamicResult)} is changed (double -> float (Single))\n" +
					$"{nameof(dynamicResult)} Value: {dynamicResult}");

dynamicResult = 505442320.72137D;
Console.WriteLine($"\n\n{nameof(dynamicResult)} is changed (float -> decimal (Decimal))\n" +
					$"{nameof(dynamicResult)} Value: {dynamicResult}");

dynamicResult = 213771327L;
Console.WriteLine($"\n\n{nameof(dynamicResult)} is changed (decimal -> long (Int64))\n" +
					$"{nameof(dynamicResult)} Value: {dynamicResult}");