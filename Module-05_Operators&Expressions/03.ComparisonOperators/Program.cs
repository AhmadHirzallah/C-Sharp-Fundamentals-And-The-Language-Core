Console.WriteLine("\n::::::::: Payment Verification :::::::::\n");


decimal invioceTotal = 550.00M;
decimal ahmadPaidInvoiceAmount = 540.00M;
decimal omarPaidInvoiceAmount = 550.00M;

//! Boolean variable is prefered to be PREFIXED with questioning like "is" or "has" to indicate that it is a boolean value.
bool isAhmadInvoiceFullyPaid = ahmadPaidInvoiceAmount >= invioceTotal;
bool isOmarInvoiceFullyPaid = omarPaidInvoiceAmount >= invioceTotal;
Console.WriteLine($"[Invoice Total]: {invioceTotal}");
Console.WriteLine($"Ahmad Paid Invoice Amount: {ahmadPaidInvoiceAmount}\n" +
	$"Is the Ahmad's Invoice Fully Paid? {isAhmadInvoiceFullyPaid}\n\n");
Console.WriteLine($"Omar Paid Invoice Amount: {omarPaidInvoiceAmount}\n" +
	$"Is the Omar's Invoice Fully Paid? {isOmarInvoiceFullyPaid}");



Console.WriteLine("\n\n\n::::::::: Credit Limit Check :::::::::\n");

decimal creditLimit = 10000.00m;
decimal purchaseAmount = 12000.00m;
bool exceedsLimit = purchaseAmount > creditLimit;
Console.WriteLine($"Credit Limit: {creditLimit}\n" +
	$"Purchase Amount: {purchaseAmount}\n" +
	$"Exceeds Credit Limit: {exceedsLimit}");



Console.WriteLine("\n\n\n::::::::: Maximum Human Age :::::::::\n");

byte MaximumHumanAge = 150;
byte AliAge = 123;
bool doesReachedMaxHumanAge = AliAge == MaximumHumanAge;
Console.WriteLine($"Does Ali Reached Maximum Human Age: {doesReachedMaxHumanAge}");



Console.WriteLine("\n\n\n::::::::: Working Hours Validation :::::::::\n");
byte requiredWorkerHours = 160;
int actualWorkerWorkedHours = 165;

bool doesWorkerMeetsRequirement = actualWorkerWorkedHours >= requiredWorkerHours;

Console.WriteLine($"Required Worker Hours: {requiredWorkerHours}\n" +
	$"Actual Worker Worked Hours: {actualWorkerWorkedHours}\n" +
	$"{nameof(doesWorkerMeetsRequirement)}: {doesWorkerMeetsRequirement}");



Console.WriteLine("\n\n\n::::::::: Coupon Validation :::::::::\n");

const string validEnteredPromoCode = "SAVE10";
string appliedUserPromoCode = "SAVE20";

bool isInvalidPromo = validEnteredPromoCode != appliedUserPromoCode;

Console.WriteLine($"{nameof(validEnteredPromoCode)}: {validEnteredPromoCode}\n" +
	$"{nameof(appliedUserPromoCode)}: {appliedUserPromoCode}\n" +
	$"Promo INVALID: {isInvalidPromo}");




Console.WriteLine("\n\n\n::::::::: Example with Order Execution comments :::::::::\n");


int totalOrders = 25;
int minimumOrdersForBonus = 20;

bool qualifiesForBonus = totalOrders >= minimumOrdersForBonus;

//! Evaluation steps:
//*	   • Evaluate the left operand expression: [[totalOrders]].
//*	   • Evaluate the right operand expression: [[minimumOrdersForBonus]].
//*	   • Apply the comparison operator => [left operand expression] [[comparison operator]] [[right operand expression]] .
//*	   • Apply the comparison operator => [totalOrders] [[>=]] [[minimumOrdersForBonus]] .
//*	   • Produce a [[bool]] result .
//*	   • Assign the result (if part of an assignment) [[qualifiesForBonus = ...]].


//! Key Rules
//*   • [Comparison operators] always return [[bool]].
//*   • They do not modify values.
//*   • Both sides must be [[comparable types]].
//*   • [[Precision]] matters when comparing [[numeric types as in: float, decimal, double]].

//! Common Mistakes
//*   • Confusing = with ==.
//*   • Comparing floating-point numbers without understanding precision.
//*   • Assuming comparison changes variable value.


//! Comparison operators allow you to:
//*   • Validate payments
//*   • Enforce limits
//*   • Check requirements
//*   • Drive logical decisions
//*   • They transform numeric values into boolean decisions.
