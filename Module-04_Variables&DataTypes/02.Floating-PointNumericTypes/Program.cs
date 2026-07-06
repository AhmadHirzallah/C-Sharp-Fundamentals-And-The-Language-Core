#region (float) - Float - [System.Single] - (From [±1.5e−45 to ±3.4e38])

Console.WriteLine("\n\n---------------------------------\n\n");

//! Use Case: small differences like temperature change, level adjustment, etc.
//*		Scientific calculations, game physics, ML data
{
	//? Compile Time Error: The literal 23.75 of type double cannot be implicitly converted to type 'float'. An explicit conversion exists (are you missing a cast?).
	//float temperatureAverage = 23.75;
	float temperatureAverage_f = 23.75F;
	float temperatureAverage_F = 23.75f;
	Console.WriteLine($"1) float: {nameof(temperatureAverage_f)} = {temperatureAverage_f}");
	Console.WriteLine($"2) float: {nameof(temperatureAverage_F)} = {temperatureAverage_F}");

	Console.WriteLine($"\n\n(float) - [System.Single]: {nameof(System.Single.MinValue)} = {Single.MinValue}");
	Console.WriteLine($"(float) - [System.Single]: {nameof(float.MaxValue)} = {float.MaxValue}");
}

Console.WriteLine("\n\n---------------------------------\n\n");

#endregion


#region Float (float) -> The 7 Digits (Maximum Capacity) Precision Problem

//! Use Case: small differences like temperature change, level adjustment, Money
//*		- Using float with these could make problems because of the precision issue.
{
	float numWorking = 1234567;
	Console.WriteLine($"{nameof(numWorking)} = {numWorking}");

	float numNotWorking = 123456789;
	Console.WriteLine("The '1234567' will be taken without problems; but the '89' numbers will be rounded to '90' as Below:");

	Console.WriteLine($"\n{nameof(numNotWorking)} = {numNotWorking}");

	Console.WriteLine("\nFloat is 32 Bits (4 Bytes) which can't store more than [7] digits accurately" +
		"\n  And as we have a 9 digits number: [123456789] (Range is bigger than [float]) so it will be " +
		"Rounded the number.");
}

Console.WriteLine("\n\n---------------------------------\n\n");

#endregion


#region Double (double) - Default Floating Point Type in C# - [System.Double] - (From [±5.0e−324 to ±1.7e308])

//! Use Case: General-purpose real numbers, measurements, engineering calculations - It gives perfect capacity and precision for most of the cases.
{
	double distanceInKilometers_DefaultNo_D = 1250.5678;
	double distanceInKilometers_WithSuffixLiteral1 = 1250.5678d;
	double distanceInKilometers_WithSuffixLiteral2 = 1250.5678D;

	Console.WriteLine("No Need to the Suffix Literal `d` or `D` for double values." +
		"\n No Need to do '123.65d' or '123.65D' as (double) is the default type for floating-point literals.\n");
	Console.WriteLine($"1) double: {nameof(distanceInKilometers_DefaultNo_D)} = {distanceInKilometers_DefaultNo_D}");
	Console.WriteLine($"2) double: {nameof(distanceInKilometers_WithSuffixLiteral1)} = {distanceInKilometers_WithSuffixLiteral1}");
	Console.WriteLine($"3) double: {nameof(distanceInKilometers_WithSuffixLiteral2)} = {distanceInKilometers_WithSuffixLiteral2}");

	Console.WriteLine("\n");

	Console.WriteLine($"(double) - {nameof(System.Double)}: {nameof(System.Double.MinValue)} = {System.Double.MinValue}");
	Console.WriteLine($"(double) - {nameof(System.Double)}: {nameof(System.Double.MaxValue)} = {System.Double.MaxValue}");
}

Console.WriteLine("\n\n---------------------------------\n\n");


#endregion


#region Decimal (decimal) -

//! Use Case: 16 Bytes
//*		- مخصص للحسابات المالية ودقته عالية جداً ويستطيع تمثيل الأرقام العشرية بمنتهى الدقة وبدون أخطاء
//*		- Financial values, currency, precise decimal calculations
//*		- Gives High Range: ±1.0e−28 to ±7.9e28
//*		- Used in: Financial Values, Currency, precise decimal calculations.

{
	//! - This is a compile-time error because the default type for [floating-point] literals is 
	//!  [[double]], and it cannot be implicitly converted to decimal.
	//! - You need to use the suffix `m` or `M` to indicate that the literal is of type decimal.
	//decimal accountBalanceCompileError = 125000.75;
	decimal accountBalance1 = 125001.75m;
	decimal accountBalance2 = 125002.75M;

	Console.WriteLine($"(decimal) - {nameof(System.Decimal)}: {nameof(accountBalance1)} = {accountBalance1}");
	Console.WriteLine($"(decimal) - {nameof(System.Decimal)}: {nameof(accountBalance2)} = {accountBalance2}");

	Console.WriteLine($"\n\n(decimal) - {nameof(System.Decimal)}: {nameof(System.Decimal.MinValue)} = {System.Decimal.MinValue}");
	Console.WriteLine($"(decimal) - {nameof(System.Decimal)}: {nameof(decimal.MaxValue)} = {decimal.MaxValue}");


}

Console.WriteLine("\n\n---------------------------------\n\n");

#endregion