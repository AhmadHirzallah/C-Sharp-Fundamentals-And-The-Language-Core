//! Represent Whole Numbers - أنواع عددية صحيحة كاملة بدون جزء كسري
//? We can use C# Type/Keyword:
//*		(sbyte, byte, short, ushort, int, uint, long, ulong) to represent whole numbers without fractional parts.
//? OR - .NET Types:
//*		(System.SByte, System.Byte, System.Int16, System.UInt16, System.Int32, System.UInt32, System.Int64, System.UInt64)

//! -------------------- [sbyte & byte] --------------------

#region [[sbyte]] [System.SByte] -- Range [-128 To 127]

//! Use Case: small differences like temperature change, level adjustment, etc.

{
	//? Initialization = Declaration + Assignment
	sbyte sbyteTemperatureChange = -10; // Represents a small temperature change

	//? Declaration Only
	sbyte sbyteLevelAdjustment;

	//? Assignment Only
	sbyteLevelAdjustment = 5; // Represents a small level adjustment
	Console.WriteLine($"1) sbyte: {nameof(sbyteLevelAdjustment)} = {sbyteLevelAdjustment}\n" +
		$"2) sbyte: {nameof(sbyteTemperatureChange)} = {sbyteTemperatureChange}");

}
//! The name 'sbyteTemperatureChange' does not exist in the current context
//* Can't use the variable/identifier outside its defining/declaring scope (block of code) because it is defined inside a block (curly braces).
//Console.WriteLine(sbyteTemperatureChange);


{
	//! I can reuse the variable name 'sbyteTemperatureChange' in a different block of code (scope) without any conflict.
	sbyte sbyteTemperatureChange = -33;
	Console.WriteLine($"3) sbyte: {nameof(sbyteTemperatureChange)} = {sbyteTemperatureChange}");

	//! Identifiers/Variables Names -> Case Sensitive
	sbyte sByteTemperatureChange = -33;
	Console.WriteLine($"4) sbyte: {nameof(sByteTemperatureChange)} = {sByteTemperatureChange}");
}

{
	//! Rather than C# Type/Keyword, we can use .NET Type to represent whole numbers without fractional parts.
	System.SByte sbyteTemperatureChange = -10; // Represents a small temperature change
	Console.WriteLine($"5) sbyte: {nameof(sbyteTemperatureChange)} = {sbyteTemperatureChange}");
}

{
	Console.WriteLine("\n\n---------------------------------");

	Console.WriteLine($"[sbyte] - [System.SByte]: {nameof(System.SByte.MinValue)} = {System.SByte.MinValue}");
	Console.WriteLine($"[sbyte] - [System.SByte]: {nameof(System.SByte.MaxValue)} = {System.SByte.MaxValue}");

	//! .NET ECO System allows you to get the Minimum and Maximum values of the numeric types using the static properties MinValue and MaxValue.
	Console.WriteLine($"\nsbyte {nameof(System.SByte.MinValue)} = {System.SByte.MinValue}");
	Console.WriteLine($"sbyte {nameof(sbyte.MaxValue)} = {sbyte.MaxValue}");

}

#endregion


#region [[byte]] [System.Byte] -- Range [0 To 255]

//! Use Case: Age, retry attempts, small counters.
//*		- We don't use [short], [int], [long], ... etc. to represent [[Age]] because they are too big to represent [[Age]] and they will waste memory space.
//*			- الذاكرة لها تكلفة ويجب أن يكون لدينا ترشيد بالإستهلاك ونستخدم ما هو مناسب فقط.
//*		- You can't have a (-) Age => So no need to use the signed type (sbyte) to represent [[Age]], instead use the unsigned type (byte) to represent [[Age]].
{
	byte byteMaxretryAttempts = 5; // Represents the maximum number of retry attempts

	Console.WriteLine("\n\n\n------------------------------------------");
	Console.WriteLine($"1) byte {nameof(byteMaxretryAttempts)} = {byteMaxretryAttempts}");
	Console.WriteLine($"2) byte - [System.Byte]: {nameof(byte.MinValue)} = {byte.MinValue}\n"
		+ $"3) byte - [System.Byte]: {nameof(byte.MaxValue)} = {System.Byte.MaxValue}");
}
#endregion


//! -------------------- [short & ushort] --------------------

#region Short -- Range [(-32,768) To (32,767)]

//! Use Case:
//*		- Elevation: (ارتفاع وقد يكون ارتفع تحت مستوى معين كأنك تنظر للأسفل بالتالي سيكون سالب
//*			(مثال: الإنخفاض تحت مستوى سطح البحر)),
//*		- depth, small quantity counts/small distances, etc.
//*		- Common in Embedded Systems, Binary Protocols, and File Formats where memory efficiency is crucial.
//*		- And Common in Interop Scenarios with C/C++ libraries that use 16-bit integers.
//*			- Interoperability (interop) scenarios describe how different systems, frameworks, or AI assistants communicate and share data
//*			- Common use cases include calling native C/C++ libraries in C# via platform invoke (DllImport), connecting AI co-pilots across separate applications (using tools like the Model Context Protocol), or linking web and desktop apps to pass data contextually.
{
	Console.WriteLine("\n\n\n------------------------------------------");
	short elevationInMeters = -500; // Represents an elevation below sea level

	//! ERROR: You got this error because the nameof operator requires a variable, type, or member name, and it does not accept C# built-in primitive type aliases (keywords) like short, int, or string
	//Console.WriteLine($"{nameof(Int16)} -- {nameof(short)}");
	Console.WriteLine($"{nameof(Int16)} -- [[short]]");
	Console.WriteLine($"{nameof(Int16)} => [16] Because it is [16 Bits] = [2 Bytes].");
	Console.WriteLine($"short - [Int16]: {nameof(short.MinValue)} = {short.MinValue}");
	Console.WriteLine($"short - [Int16]: {nameof(System.Int16.MaxValue)} = {Int16.MaxValue}");
	Console.WriteLine($"{nameof(elevationInMeters)} = {elevationInMeters}");
}

#endregion


#region Unsigned Short (ushort) [System.UInt16] -- Range [(0) To (65,535)]

//! Use Case:
//*		- Capacities, counts, Stock Quantity and other non-negative values that fit within 16 bits.

{
	Console.WriteLine("\n\n\n------------------------------------------\n");
	//! Warehouse - المخزن
	ushort wareHouseCapacity = 50000; // Represents the capacity of a warehouse in units
	System.UInt16 stockQuantity = 30000; // Represents the current stock quantity in units

	Console.WriteLine($"{nameof(System.UInt16)} - [ushort]: {nameof(ushort.MinValue)} = {ushort.MinValue}");
	Console.WriteLine($"{nameof(System.UInt16)} - [ushort]: {nameof(System.UInt16.MaxValue)} = {UInt16.MaxValue}");

	Console.WriteLine($"1) {nameof(wareHouseCapacity)} = {wareHouseCapacity}");
	Console.WriteLine($"2) {nameof(stockQuantity)} = {stockQuantity}");
}

#endregion


//! -------------------- [int & uint] --------------------

#region Integer (int) [System.Int32] && [[The Default Data Type in .NET]] -- Range [(-2,147,483,648) To (2,147,483,647)]

//! Use Case:
//*		- EmployeeId, Revenue (ربح ودخل), Distances, Population counts, financial transactions, and other values that fit within 32 bits.

Console.WriteLine("\n\n\n------------------------------------------\n");

{
	//? In ($ Dollar) - أقل عملة موجودة هي السنت => So their is no fractions (لا يوجد أعشار) => So: [int] is the best choice to represent the balance in cents (125,000 cents = 1,250.00 $).
	int balanceInCents = 125000;
	Console.WriteLine($"int - (Int32): {nameof(System.Int32.MinValue)} = {Int32.MinValue}");
	Console.WriteLine($"int - (Int32): {nameof(int.MaxValue)} = {int.MaxValue}");
	Console.WriteLine($"int - (Int32): {nameof(balanceInCents)} = {balanceInCents}");

	//! [int], [[System.Int32]] is the Default Data Type in C#
	var defaultInteger = 100; // The compiler infers the type as int (System.Int32) by default
	Console.WriteLine("\n\n[int], [[System.Int32]] is the Default Data Type in C#");
	Console.WriteLine($"\nvar {nameof(defaultInteger)} = {defaultInteger}");
	Console.WriteLine($"\nType Of: {nameof(defaultInteger)} is: {defaultInteger.GetType()}");
}

#endregion

#region Unsigned Integer (uint) [System.UInt32] -- Range [(0) To (4,294,967,295)]

Console.WriteLine("\n\n\n------------------------------------------\n");

//! Use Case:
//*		- Large counts & counters, IDs and keys [to be compatible with SQL Server and others], Video View Counts, File Total Downloads, and other non-negative values that fit within 32 bits.
{
	uint totalDownloads = 3_294_967_295; // Represents the total number of downloads for a file
	uint MaxAvailableDownloads = 4_294_967_295; // Represents the total number of downloads for a file

	Console.WriteLine($"uint - {nameof(UInt32)}: {nameof(totalDownloads)} = {totalDownloads}");
	Console.WriteLine($"uint - {nameof(UInt32)}: {nameof(MaxAvailableDownloads)} (Max uint) = {MaxAvailableDownloads}");
	Console.WriteLine($"\n\nuint - {nameof(UInt32)}: {nameof(UInt32.MinValue)} = {UInt32.MinValue}");
	Console.WriteLine($"uint - {nameof(UInt32)}: {nameof(uint.MaxValue)} = {uint.MaxValue}");
}
Console.WriteLine("\n\n\n------------------------------------------\n");

#endregion


//! -------------------- [long & ulong] --------------------

#region Long - (long) -> [System.Int64] -- Range [(-9,223,372,036,854,775,808) To (9,223,372,036,854,775,807)]

Console.WriteLine("\n\n\n------------------------------------------\n");

{
	//! Use Case:
	//*		- File Sizes, population counts, astronomical/long distances, Time Stamps, Very Large Counters, Financial Calculations without decimals and other values that fit within 64 bits.
	long fileSizeInBytes = 9_223_372_036_854_775_807; // Represents a large file size in bytes
	Console.WriteLine($"long - {nameof(System.Int64)}: {nameof(fileSizeInBytes)} = {fileSizeInBytes}");

	Console.WriteLine($"\n\nlong - {nameof(System.Int64)}: {nameof(Int64.MinValue)} = {Int64.MinValue}");
	Console.WriteLine($"long - {nameof(Int64)}: {nameof(long.MaxValue)} = {long.MaxValue}");

}

#endregion


#region Unsigned Long - (ulong) -> [System.UInt64] -- Range [(0) To (18,446,744,073,709,551,615)]

Console.WriteLine("\n\n\n------------------------------------------\n");

//! Use Case:
//*		- Large counts & counters (Positive), IDs and keys [to be compatible with SQL Server and others], Storage Capacity, Big Identifiers, Video View Counts, File Total Downloads, and other non-negative values that fit within 64 bits.
{
	ulong totalStorageCapacityInBytes = 18_446_744_073_709_551_615; // Represents the total storage capacity in bytes

	Console.WriteLine($"ulong - {nameof(System.UInt64)}: {nameof(totalStorageCapacityInBytes)} = {totalStorageCapacityInBytes}");

	Console.WriteLine($"\nulong - {nameof(UInt64)}: {nameof(UInt64.MinValue)} = {UInt32.MinValue}");
	Console.WriteLine($"ulong - {nameof(UInt64)}: {nameof(long.MaxValue)} = {long.MaxValue}");


}
Console.WriteLine("\n\n\n------------------------------------------\n");

#endregion