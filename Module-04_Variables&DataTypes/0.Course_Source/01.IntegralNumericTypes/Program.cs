// sbyte
// Range: -128 to 127
// Use case: small differences like temperature change, level adjustment

// System.SByte temperature;
sbyte temperature;

temperature = -12;
Console.WriteLine("Sbyte: [" + System.SByte.MinValue + "->" + System.SByte.MaxValue + "]");
Console.WriteLine("temperature: " + temperature);


// byte
// Range: 0 to 255
// Use case: age,  retry attempts, small counters

byte maxRetryAttempts = 5;
Console.WriteLine("Byte: [" + System.Byte.MinValue + "->" + System.Byte.MaxValue + "]");
Console.WriteLine("maxRetryAttempts: " + maxRetryAttempts);

// short
// Range: -32,768 to 32,767
// Use case: elevation, small quantity counts

short elevationInMeters = -320;
Console.WriteLine("Int16 (short): [" + System.Int16.MinValue + "->" + System.Int16.MaxValue + "]");
Console.WriteLine("elevationInMeters: " + elevationInMeters);


// ushort
// Range: 0 to 65,535
// Use case: capacity, stock quantity

ushort warehouseCapacity = 50000;
Console.WriteLine("UInt16 (ushort): [" + System.UInt16.MinValue + "->" + System.UInt16.MaxValue + "]");
Console.WriteLine("warehouseCapacity: " + warehouseCapacity);

// int
// Range: -2,147,483,648 to 2,147,483,647
// Use case: employeeId, revenue, distances


int balanceInCents = 125000;
Console.WriteLine("Int32 (int): [" + System.Int32.MinValue + "->" + System.Int32.MaxValue + "]");
Console.WriteLine("balanceInCents: " + balanceInCents);


// uint
// Range: 0 to 4,294,967,295
// Use case: large counters, view counts

uint totalDownloads = 4000000000;
Console.WriteLine("UInt32 (uint): [" + System.UInt32.MinValue + "->" + System.UInt32.MaxValue + "]");
Console.WriteLine("totalDownloads: " + totalDownloads);


// long
// Range: very large signed numbers
// Use case: file sizes, timestamps, long distances

long fileSizeInBytes = 900000000000;
Console.WriteLine("Int64 (long): [" + System.Int64.MinValue + "->" + System.Int64.MaxValue + "]");
Console.WriteLine("fileSizeInBytes: " + fileSizeInBytes);

// ulong
// Range: very large positive numbers
// Use case: storage capacity, big identifiers


ulong totalStorageCapacity = 10000000000000000000;
Console.WriteLine("UInt64 (ulong): [" + System.UInt64.MinValue + "->" + System.UInt64.MaxValue + "]");
Console.WriteLine("totalStorageCapacity: " + totalStorageCapacity);