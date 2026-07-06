
//! Key Rules
//?	   • Result type depends on operand types (Operand types means: Used DateTypes: [int]/[int] => Fraction is removed!).
//?	   • Integer division discards fractional part.
//?	   • [[%]] returns remainder, not percentage.
//?	   • Use [[decimal]] for financial calculations.

//! Common Mistakes
//?	   • Using [[int]] division when [[decimal - أعشار]] result is expected.
//?	   • Using [[double]] for money calculations - الدقة أقل وقد تخسر بعض الدقة والبيانات - Causing Loss of Data.
//?	   • Assuming [[%]] calculates percentage.



#region Addition (`+`): Adds two numeric values.

//! In Financial applications, the `decimal` type is often preferred for monetary calculations due to its higher precision and ability to represent decimal fractions accurately. This is crucial when dealing with currency values, as it helps avoid rounding errors that can occur with floating-point types like `float` or `double`.
Console.WriteLine(" \n::::::::: Addition :::::::::\n");

decimal productPrice = 150.00m;
decimal shippingCost = 33.00M;
decimal invoiceTotal = productPrice + shippingCost;

//double invoiceTotalCompileError = productPrice + shippingCost;
double invoiceTotalDouble = (double)productPrice + (double)shippingCost;
double invoiceTotalDouble2 = (double)(productPrice + shippingCost);

Console.WriteLine("----- INVOICE -----\n" +
	$"Product Price: ${productPrice}\n" +
	$"Shipping Cost: ${shippingCost}\n" +
	$"---------------------\n" +
	$"Total:	${invoiceTotal}");

#endregion

#region Subtraction (`-`): Subtracts one value from another

Console.WriteLine("\n\n::::::::: Subtraction :::::::::\n");

decimal accountBalance = 5000.00m;
decimal withdrawalAmount = 1200.00m;
decimal remainingBalanceAfterWithdrawal = accountBalance - withdrawalAmount;

Console.WriteLine("----- ACCOUNT SUMMARY -----\n" +
	$"Account Balance: ${accountBalance}\n" +
	$"Withdrawal Amount: ${withdrawalAmount}\n" +
	$"---------------------------\n" +
	$"Remaining Balance: ${remainingBalanceAfterWithdrawal}");

#endregion

#region Multiplication (`*`): Multiplies numeric values

Console.WriteLine("\n\n::::::::: Multiplication :::::::::\n");

decimal hourlyRate = 50.00M;
int workedHours = 160;

decimal monthlySalary = hourlyRate * workedHours;

//! Because both operands are decimal and int, the result is inferred as decimal as [decimal] is the more precise type. (The rule that make compiler choose the more precise type is called "type promotion" or "type inference".)/! Because both operands are decimal and int, the result is inferred as decimal as [decimal] is the more precise type. (The rule that make compiler choose the more precise type is called "type promotion" or "type inference".)
var monthlySalaryAutoDecimal = hourlyRate * workedHours;

Console.WriteLine("----- SALARY SUMMARY -----\n" +
	$"Hourly Rate: ${hourlyRate}\n" +
	$"Worked Hours: {workedHours}\n" +
	$"-------------------------\n" +
	$"Monthly Salary: ${monthlySalary}");

#endregion


#region Division (`/`): Division behavior depends on operand types

Console.WriteLine("\n\n::::::::: Division :::::::::\n");

int totalItems = 7;
byte itemsPerBox = 2;

int boxCount = totalItems / itemsPerBox; //! Integer division (int/byte), result is an integer
var boxCountAutoInt = totalItems / itemsPerBox; //! Integer division (int/byte), result is an integer

Console.WriteLine("----- BOX COUNT -----\n" +
	$"Total Items: {totalItems}\n" +
	$"Items Per Box: {itemsPerBox}\n" +
	$"-------------------\n" +
	$"Box Count: {boxCount}");

Console.WriteLine("\n\n!!!\tNote that (Integral Types Divisions) will truncate any fractional part." +
	"So, be careful when performing division with integral types; specially in production scenarios.");


Console.WriteLine("\n\n\n~~~~~~~~ New Division Scenario ~~~~~~~~~\n");
decimal totalRevenue = 1000.00M; //! مجموع الأرباح
decimal numberOfMonths = 3.00M; //! عدد الأشهر

//! نريد حساب معدل الربح الشهري
decimal monthlyAverageRevenue = totalRevenue / numberOfMonths; //! Division of two decimal values, result is decimal
var dailyAverageRevenue = totalRevenue / (numberOfMonths * 30); //! Division of two decimal values, result is decimal


Console.WriteLine("----- MONTHLY REVENUE SUMMARY -----\n" +
	$"Total Monthly Revenue: ${totalRevenue}\n" +
	$"Number of Months: {numberOfMonths}\n" +
	$"---------------------------\n" +
	$"Monthly Average Revenue: ${monthlyAverageRevenue}");


Console.WriteLine("\n\n----- DAILY REVENUE SUMMARY -----\n" +
	$"Total Monthly Revenue: ${totalRevenue}\n" +
	$"Number of Months: {numberOfMonths}\n" +
	$"---------------------------\n" +
	$"Monthly Average Revenue: ${monthlyAverageRevenue}\n" +
	$"Daily Average Revenue: ${dailyAverageRevenue}");

#endregion

#region Modulus (`%`): Returns the remainder after division.

Console.WriteLine("\n\n::::::::: Modulus (`%`) :::::::::\n");

int totalUnits = 23;
byte unitsPerBox = 5;

int remainingUnits = totalUnits % unitsPerBox; //! Modulus operation (int % byte), result is an integer

Console.WriteLine("----- REMAINING UNITS -----\n" +
	$"Total Units: {totalUnits}\n" +
	$"Units Per Box: {unitsPerBox}\n" +
	$"---------------------------\n" +
	$"Remaining Units: {remainingUnits}");

#endregion

