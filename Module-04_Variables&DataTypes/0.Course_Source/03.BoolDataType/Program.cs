// bool represents a logical value that can be only one of two states:true or false
// Internally stored as 1 byte (8 bits)
//      true → 00000001
//      false → 00000000
// Common in condition checks (if, while) Used to model flags and validation results


bool isActive = true;
System.Boolean isDeleted = false;

Console.WriteLine("isActive: " + isActive);
Console.WriteLine("isDeleted: " + isDeleted);

Console.WriteLine("bool: [" + true + " Or " + false + "]");

Console.WriteLine("bool size: " + sizeof(bool));

