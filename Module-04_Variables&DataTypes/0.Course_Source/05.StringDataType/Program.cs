// string represents a sequence of UTF-16 Unicode characters
// Reference type (System.String)
// Internally stores characters as a contiguous array of char
// Each character occupies 2 bytes (UTF-16)
// Immutable (cannot be modified after creation)
// Used for text, names, messages, identifiers, and full input values

string currencyCode = "USD";
Console.WriteLine("currencyCode: " + currencyCode);

string studentFullName = "Ahmad Ali";
Console.WriteLine("student Full Name: " + studentFullName);

string orderReference = "ORD-2026-001";
Console.WriteLine("order#: " + orderReference);

Console.WriteLine("Length (orderReference): " + orderReference.Length);