//! bool represents a logical value that can be only one of two states: true or false
//* Internally stored as 1 byte (8 bits)
//?      true → 00000001
//?      false → 00000000
// ! Common in condition checks (if, while) Used to model flags and validation results

bool isActive = true;
System.Boolean isDeleted = false;

Console.WriteLine($"{nameof(isActive)} = {isActive}");
Console.WriteLine($"{nameof(isDeleted)} = {isDeleted}");

Console.WriteLine($"{nameof(System.Boolean)} - (bool) returns: {System.Boolean.TrueString} / {bool.FalseString}");
Console.WriteLine($"{System.Boolean.TrueString} = [00000001]\n" +
	$"{bool.FalseString} = [00000000]");

//Console.WriteLine($"\n(bool) size: " + sizeof(bool));
Console.WriteLine($"\n(bool) size: {sizeof(bool)} Bytes");