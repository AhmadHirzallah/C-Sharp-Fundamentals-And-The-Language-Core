// char represents a single UTF-16 Unicode code unit
// Size: 2 bytes (16 bits)
// Stores the numeric Unicode value of the character
// Used in parsing, tokenizing, and character-level validation
// Models a single symbol, letter, or digit

char currencySymbol = '$'; // in decimal 36
Console.WriteLine("currencySymbol: " + currencySymbol);

System.Char studentGrade = 'A'; // in decimal 65
Console.WriteLine("studentGrade: " + studentGrade);

Console.WriteLine("System.Char (size): " + sizeof(char)); // 2