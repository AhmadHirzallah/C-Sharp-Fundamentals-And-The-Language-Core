// float
// Range: ±1.5e−45 to ±3.4e38
// Use case: scientific calculations, game physics, ML data

float temperatureAverage = 23.75f;
Console.WriteLine("Single (float): [" + System.Single.MinValue + " -> " + System.Single.MaxValue + "]");
Console.WriteLine("temperatureAverage: " + temperatureAverage);

float num1 = 1234567;
Console.WriteLine(num1);

float num2 = 123456789;
Console.WriteLine(num2);


// double
// Range: ±5.0e−324 to ±1.7e308
// Use case: general-purpose real numbers, measurements, engineering calculations

double distanceInKilometers = 1250.5678;
Console.WriteLine("Double (double): [" + System.Double.MinValue + " -> " + System.Double.MaxValue + "]");
Console.WriteLine("distanceInKilometers: " + distanceInKilometers);

// decimal
// Range: ±1.0e−28 to ±7.9e28
// Use case: financial values, currency, precise decimal calculations

decimal accountBalance = 125000.75m;
Console.WriteLine("Decimal (decimal): [" + System.Decimal.MinValue + " -> " + System.Decimal.MaxValue + "]");
Console.WriteLine("accountBalance: " + accountBalance);