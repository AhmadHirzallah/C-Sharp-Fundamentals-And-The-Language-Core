//! char represents a single UTF-16 Unicode code unit
//? Size: 2 bytes (16 bits)
//* - Stores the numeric Unicode value of the character
//* - Used in parsing, tokenizing, and character-level validation
//*		- التحليل، والتقسيم إلى رموز، والتحقق من صحة الأحرف
//* - Models a single symbol, letter, or digit

System.Char currentSymbol = '$'; //! ($) value in decimal is: (36)
Console.WriteLine($"{nameof(currentSymbol)} = {currentSymbol}");

char studentGrade = 'A'; //! (A) value in decimal is: (65)
Console.WriteLine($"{nameof(studentGrade)} = {studentGrade}");
Console.WriteLine($"{nameof(currentSymbol.GetTypeCode)} -> {currentSymbol.GetTypeCode()}");


Console.WriteLine($"\n\n{nameof(char.MinValue)} -> {char.MinValue}");
Console.WriteLine($"{nameof(System.Char.MaxValue)} -> {System.Char.MaxValue}");

Console.WriteLine($"\n{nameof(System.Char)} - (char) size: {sizeof(char)} bytes");

Console.WriteLine($"\n{nameof(currentSymbol.ConvertFromUtf32)} -> {char.ConvertFromUtf32(currentSymbol)}");

//? char.ConvertToUtf32(string s, int index) signature; Passed (0) as the index of the character in the string representation of the currentSymbol
Console.WriteLine($"{nameof(char.ConvertToUtf32)} -> {char.ConvertToUtf32(currentSymbol.ToString(), 0)}");

Console.WriteLine("\n\nYou see characters as characters; But they are stored as [UTF-16] Unicode units");