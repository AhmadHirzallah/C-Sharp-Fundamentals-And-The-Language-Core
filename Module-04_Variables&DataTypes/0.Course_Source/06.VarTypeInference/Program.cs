// var` lets the compiler infer the type automatically
// The type is determined at **compile time**
// The variable remains strongly typed

var number = 10;        // int
var price = 10.5;       // double
var grade = 'A';        // char
var isActive = true;    // bool
var salary = 10000m;

Console.WriteLine("number: " + number);
Console.WriteLine("price: " + price);
Console.WriteLine("grade: " + grade);
Console.WriteLine("isActive: " + isActive);

// var studentNumber;  // ERROR: Must be initialized immediately

var studentNumber = 10000;
// studentNumber = 3.5;  // ERROR: Cannot change type later