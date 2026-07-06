//! - (string) represents a sequence of UTF-16 Unicode characters
//! - Reference type (System.String)
//! - Internally stores characters as a contiguous array of char
//! - Each character occupies 2 bytes (UTF-16)
//! - Immutable (cannot be modified after creation)
//? - Used for text, names, messages, identifiers, and full input values


string currencyCode = "USD";
Console.WriteLine($"{nameof(currencyCode)} = {currencyCode}");

string studentFullName = "Ahmad Omar Ibrahim Hirzallah";
Console.WriteLine($"{nameof(studentFullName)} = {studentFullName}");


System.String orderReference = "ORD-2026-001";
Console.WriteLine($"\n{nameof(orderReference)}: #{orderReference}");
Console.WriteLine($"Length of {nameof(orderReference)}: [{orderReference.Length}]");

Console.WriteLine($"\n\nLength of \"Ahmad\" is: {"Ahmad".Length}");
