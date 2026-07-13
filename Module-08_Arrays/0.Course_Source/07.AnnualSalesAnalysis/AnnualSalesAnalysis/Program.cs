Console.WriteLine(":::::::::::::::: ANNUAL SALES REPORT ::::::::::::::::");

string[] months =
{
    "Jan","Feb","Mar","Apr","May","Jun",
    "Jul","Aug","Sep","Oct","Nov","Dec"
};

// 12 months × 10 sales per month
decimal[,] yearlySales =
{
    { 120m, 450m, 0m, 75m, 300m, 500m, 210m, 0m, 275m, 660m },      // Jan
    { 800m, 0m, 300m, 210m, 400m, 600m, 0m, 120m, 950m, 430m },     // Feb
    { 950m, 400m, 300m, 0m, 200m, 450m, 600m, 700m, 0m, 150m },     // Mar
    { 600m, 750m, 0m, 120m, 340m, 890m, 230m, 410m, 260m, 0m },     // Apr
    { 1100m, 200m, 90m, 150m, 0m, 700m, 650m, 320m, 210m, 180m },   // May
    { 1300m, 0m, 700m, 200m, 350m, 600m, 420m, 390m, 0m, 260m },    // Jun
    { 700m, 300m, 400m, 0m, 280m, 620m, 510m, 330m, 240m, 170m },   // Jul
    { 900m, 100m, 0m, 200m, 350m, 480m, 720m, 510m, 300m, 0m },     // Aug
    { 1200m, 800m, 600m, 250m, 0m, 950m, 870m, 330m, 290m, 410m },  // Sep
    { 400m, 350m, 200m, 0m, 150m, 300m, 450m, 600m, 700m, 250m },   // Oct
    { 1000m, 0m, 150m, 120m, 340m, 510m, 720m, 650m, 430m, 210m },  // Nov
    { 2000m, 500m, 300m, 0m, 600m, 800m, 950m, 720m, 640m, 0m }     // Dec
};


decimal annualTotal = 0m;
decimal highestSale = yearlySales[0, 0];
int totalZeroDays = 0;

for (var month = 0; month < yearlySales.GetLength(0); month++)
{
    decimal monthlyTotal = 0m;
    int zeroDayInMonth = 0;

    for (var sale = 0; sale < yearlySales.GetLength(1); sale++)
    {
        decimal currentSale = yearlySales[month, sale];

        monthlyTotal += currentSale;

        if (currentSale > highestSale)
        {
            highestSale = currentSale;
        }

        if (currentSale == 0m)
        {
            zeroDayInMonth++;
        }
    }

    Console.WriteLine(months[month] + " .............  Total: $" + monthlyTotal + "    |  Zero Days: " + zeroDayInMonth + " day(s)");

    annualTotal += monthlyTotal;
    totalZeroDays += zeroDayInMonth;
}

Console.WriteLine("----------------------");
Console.WriteLine("Annual Total: $" + annualTotal);
Console.WriteLine("Highest Sale: $" + highestSale);
Console.WriteLine("Total Zero-Days: $" + totalZeroDays + " day(s)");