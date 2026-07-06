// ================================
// CASTING — PRIMITIVE TYPES ONLY
// ================================


// --------------------------------
// 1) What is Casting?
// --------------------------------

// Casting means converting a value
// from one primitive type to another.
// Applies to numeric types only:
// int, double, float, byte, long, etc.


// --------------------------------
// 2) Implicit Casting (Widening)
// --------------------------------

// Happens automatically
// From smaller type → larger type
// No data loss

int number = 10;
double result = number;   // implicit conversion

Console.WriteLine("result:" + result);   // 10


// --------------------------------
// 3) Explicit Casting (Narrowing)
// --------------------------------

// Requires manual cast operator
// From larger type → smaller type
// Possible data loss

double price = 9.75;
int wholePrice = (int)price;   // explicit conversion

Console.WriteLine("wholePrice: " + wholePrice);   // 9  (decimal part removed)


// --------------------------------
// 4) Data Loss Example (Overflow)
// --------------------------------

// byte range: 0 → 255

int bigNumber = 300;
byte smallNumber = (byte)bigNumber;

Console.WriteLine("smallNumber: " + smallNumber);
// 44  (300 wraps around inside byte range)


// --------------------------------
// 5) Core Rule
// --------------------------------

// Widening  → implicit
// Narrowing → explicit
// If the new type cannot safely contain the value,
// you must cast manually.
