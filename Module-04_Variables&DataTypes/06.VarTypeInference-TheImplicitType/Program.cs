//! `var` lets the compiler infer the type automatically
//* - The type is determined at **compile time**
//* - The variable remains strongly typed
//*	- It was introduced in C#3.0
//*	- This is statically typed.
//*	- We need to initialize it at the time of the declaration.
//*	- Errors are caught at compile time.
//*	- Intellisense is supported.
//*	- var does not allow the type of value assigned to be changed after it has been assigned.

#region Usages

var numberIntDefault = 10;      // [[int]]
var numberDoubleDefault = 10.5;   // [[double]]
var numberDecimal = 10.6m;   // [[decimal]]
var numberFloat = 10.7f;   // [[float]]
var numberLong1 = 10L;   // [[long]]
var numberLong2 = 10l;   //! [[long]] - The 'l' suffix is easily confused with the digit '1' -- use 'L' for clarity
var numberShort = (short)10;   // [[short]]
var isActive = false; // [[bool]]
var grade = 'A'; // [[char]]
var Name = "Ahmad";

Console.WriteLine($"Type: {numberIntDefault.GetType()} - [[int]], Identifier: {nameof(numberIntDefault)}, Value: {numberIntDefault} (from: `= 10`)");
Console.WriteLine($"Type: {numberDoubleDefault.GetType()} - [[double]], Identifier: {nameof(numberDoubleDefault)}, Value: {numberDoubleDefault} (from: `= 10.5`)");
Console.WriteLine($"Type: {numberDecimal.GetType()} - [[decimal]], Identifier: {nameof(numberDecimal)}, Value: {numberDecimal} (from: `= 10.6m`)");
Console.WriteLine($"Type: {numberFloat.GetType()} - [[float]], Identifier: {nameof(numberFloat)}, Value: {numberFloat} (from: `= 10.7f`)");
Console.WriteLine($"Type: {numberLong1.GetType()} - [[long]], Identifier: {nameof(numberLong1)}, Value: {numberLong1} (from: `= 10L`)");
Console.WriteLine($"Type: {numberLong2.GetType()} - [[long]], Identifier: {nameof(numberLong2)}, Value: {numberLong2} (from: `= 10l`)");
Console.WriteLine($"Type: {numberShort.GetType()} - [[short]], Identifier: {nameof(numberShort)}, Value: {numberShort} (from: `(short)10`)");
Console.WriteLine($"Type: {isActive.GetType()} - [[bool]], Identifier: {nameof(isActive)}, Value: {isActive} (from: `= false`)");
Console.WriteLine($"Type: {grade.GetType()} - [[char]], Identifier: {nameof(grade)}, Value: {grade} (from: `= 'A'`)");
Console.WriteLine($"Type: {Name.GetType()} - [[string]], Identifier: {nameof(Name)}, Value: {Name} (from: `= \"Ahmad\"`)");


#endregion


#region Errors

//! Errors
Console.WriteLine("\n\nImplicitly-typed variables must be initialized Immediately [[ERROR]]:");
//var studentNumber;

Console.WriteLine("\nCannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)");
var studentNumberNoChangeTypeLater = 10000;
// studentNumberNoChangeTypeLater = 2000.5; //! ERROR: Cannot change type later 


#endregion