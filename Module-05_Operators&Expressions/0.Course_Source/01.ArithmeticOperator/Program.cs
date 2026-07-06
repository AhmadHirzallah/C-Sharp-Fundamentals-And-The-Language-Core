//! Addition (`+`): Adds two numeric values.

Console.WriteLine(" \n::::::::: Addition :::::::::\n");


decimal productPrice = 150.00m;
decimal shippingCost = 25.00m;

var invoiceTotal = productPrice + shippingCost;

Console.WriteLine("----- INVOICE -----\n" +
				  "Product Price : $" + productPrice + "\n" +
				  "Shipping Cost : $" + shippingCost + "\n" +
				  "-------------------\n" +
				  "Total         : $" + invoiceTotal);



// Subtraction (`-`): Subtracts one value from another.
Console.WriteLine(" \n::::::::: Subtraction :::::::::\n");

decimal accountBalance = 5000.00m;
decimal withdrawalAmount = 1200.00m;

decimal remainingBalance = accountBalance - withdrawalAmount;

Console.WriteLine("----- BANK STATEMENT -----\n" +
				  "Initial Balance   : $" + accountBalance + "\n" +
				  "Withdrawal Amount : $" + withdrawalAmount + "\n" +
				  "---------------------------\n" +
				  "Remaining Balance : $" + remainingBalance);

// Multiplication (`*`): Multiplies numeric values.

Console.WriteLine(" \n::::::::: Multiplication :::::::::\n");

decimal hourlyRate = 50.00m;
int workedHours = 160;

decimal monthlySalary = hourlyRate * workedHours;

Console.WriteLine("----- PAYROLL SUMMARY -----\n" +
				  "Hourly Rate   : $" + hourlyRate + "\n" +
				  "Worked Hours  : " + workedHours + "\n" +
				  "----------------------------\n" +
				  "Monthly Salary: $" + monthlySalary);


//  Division (`/`): Division behavior depends on operand types.

Console.WriteLine(" \n::::::::: Division :::::::::\n");

int totalItems = 7;
int itemsPerBox = 2;

var boxCount = totalItems / itemsPerBox;

Console.WriteLine("----- PACKING SUMMARY -----\n" +
				  "Total Items   : " + totalItems + "\n" +
				  "Items Per Box : " + itemsPerBox + "\n" +
				  "-----------------------------\n" +
				  "Full Boxes    : " + boxCount);

decimal totalRevenue = 1000.00m;
decimal numberOfMonths = 3.00m;

decimal monthlyAverage = totalRevenue / numberOfMonths;


Console.WriteLine("----- REVENUE REPORT -----\n" +
				  "Total Revenue  : $" + totalRevenue + "\n" +
				  "Number of Months: " + numberOfMonths + "\n" +
				  "---------------------------\n" +
				  "Monthly Average: $" + monthlyAverage);

//  Modulus (`%`): Returns the remainder after division.

Console.WriteLine(" \n::::::::: Modulus :::::::::\n");

int totalUnits = 23;
int unitsPerBox = 5;

int remainingUnits = totalUnits % unitsPerBox;

Console.WriteLine("----- INVENTORY REMAINDER -----\n" +
				  "Total Units   : " + totalUnits + "\n" +
				  "Units Per Box : " + unitsPerBox + "\n" +
				  "-------------------------------\n" +
				  "Remaining Units: " + remainingUnits);

// Key Rules
//   • Result type depends on operand types.
//   • Integer division discards fractional part.
//   • % returns remainder, not percentage.
//   • Use decimal for financial calculations.

// Common Mistakes
//   • Using int division when decimal result is expected.
//   • Using double for money calculations.
//   • Assuming % calculates percentage.