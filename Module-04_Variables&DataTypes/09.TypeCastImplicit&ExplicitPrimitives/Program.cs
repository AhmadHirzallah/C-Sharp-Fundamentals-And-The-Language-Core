//! ================================
//! CASTING — PRIMITIVE TYPES ONLY
//! ================================


//! --------------------------------
//! 1) What is Casting?
//! --------------------------------

//?	 - Casting means converting a value
//?		from [one primitive] type to [another primitive].
//?	 - Applies to numeric types only:
//?		- int, double, float, byte, long, etc.
//?		- string -> ❎❌✖️ Not Considered.

#region Implicit Casting (Widening)

//! - توسيع الدائرة: مثل كأس من المأء وسكبه في دلو! لن تخسر أي نقطة ماء لأنك حولت من ا لصغير للكبير
//! - Happens automatically
//?		- From smaller type → larger type
//?		- No data loss
int number = 10;
double biggerContainer = number;   // implicit conversion

Console.WriteLine("[[(double) - 64 Bits]] > [[(int) - 32 Bits]] => => Implicit Conversion");
Console.WriteLine($"Original: (int): {nameof(number)} => {number}");
Console.WriteLine($"Converted Into: (double): {nameof(biggerContainer)} => {biggerContainer}");

number = int.MaxValue;
biggerContainer = number;
Console.WriteLine($"\n\nMax (int) => (double) => => No Data Loss by checking {nameof(int.MaxValue)}");
Console.WriteLine($"Original: (int): {nameof(number)} => {number}");
Console.WriteLine($"Converted Into: (double): {nameof(biggerContainer)} => {biggerContainer}");


#endregion

#region Explicit Casting (Narrowing)

Console.WriteLine("\n\n-------------------------------------\n");

//! - Narrowing: مثل دلو من المأء وسكبه في كأس! ستخسر بعض الماء لأنك حولت من الكبير للصغير
//! Requires [[manual]] cast operator
//?		- From larger type → smaller type
//?		- Possible data loss

double doubleValPrice = double.MaxValue;

//! Compiler Error: Cannot implicitly convert type 'double' to 'int'. you should use an explicit conversion (cast) to convert 'double' to 'int'
//* Error Message: "Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)"
//int intCastedPriceWrong = doubleValPrice;

int intCastedPrice = (int)doubleValPrice;   // explicit conversion
Console.WriteLine("[[(double) - 64 Bits]] > [[(int) - 32 Bits]] => => Explicit Conversion");
Console.WriteLine($"Original: (double): {nameof(doubleValPrice)} => {doubleValPrice}");
Console.WriteLine($"Converted Into: (int): {nameof(intCastedPrice)} => {intCastedPrice} => !!!!!! DATA LOSS !!!!!!");

Console.WriteLine("\n\n-------------------------------------\n");

Console.WriteLine("Byte Range: 0 to 255");
int intBiggerThanByte = 300;
byte anByte = (byte)intBiggerThanByte;

Console.WriteLine($"Original Value: {nameof(intBiggerThanByte)} => {intBiggerThanByte}");
//! (44) - (300 wraps around inside byte range: [Overflow] => 255 + 1 = 0 => 0 + 44 = 44)
Console.WriteLine($"Converted Into: (byte): {nameof(anByte)} => {anByte} => !!!!!! DATA LOSS !!!!!!");
Console.WriteLine("\nResult Value is: (44) => Because: (300 wraps around inside byte range && [Overflow]) as:\n => [[300 - 255 = 45]] => [[255 + 1 = 0]] (Still need [[+44]]) => [[0 + 44 = 44]])");
Console.WriteLine("\n\nOr: Value: 300 => Then (300 % 256) => 44\n - We used 256 because it is the range of the byte type (0 to 255)");

Console.WriteLine("\n\n-------------------------------------\n");

Console.WriteLine("No Data Loss Explicit Casting - but if (( (double) number value )) > than (( int.MaxValue )), data loss will occur.");

double price = 9.75;
int wholePrice = (int)price;   // explicit conversion

Console.WriteLine("Original Value: (double): " + price);   // 9.75
Console.WriteLine("Converted Into: (int): " + wholePrice + " => decimal part removed");   // 9  (decimal part removed)

Console.WriteLine("\n\n-------------------------------------\n");

Console.WriteLine("Core Rules:" +
	"\nWidening [From (Small) into (Large)] => implicit" +
	"\nNarrowing [From (Large) into (Small)] => explicit" +
	"\n - If the value exceeds the target type's range, data loss will occur." +
	"\n - If the new type cannot safely contain the value, then you must cast manually!.");

Console.WriteLine("\n\n-------------------------------------\n");

#endregion