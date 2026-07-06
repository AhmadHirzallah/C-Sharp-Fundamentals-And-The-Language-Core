Console.WriteLine("\n::::::::: Payment Verification :::::::::\n");

decimal invoiceTotal = 500.00m;
decimal paidAmount = 400.00m;

bool isFullyPaid = invoiceTotal == paidAmount;

Console.WriteLine("Invoice Fully Paid: " + isFullyPaid);

Console.WriteLine("\n::::::::: Credit Limit Check :::::::::\n");

decimal creditLimit = 10000.00m;
decimal purchaseAmount = 12000.00m;


bool exceedsLimit = purchaseAmount > creditLimit;

Console.WriteLine("Exceeds Credit Limit: " + exceedsLimit);

Console.WriteLine("\n::::::::: Working Hours Validation :::::::::\n");

int requiredHours = 160;
int actualWorkedHours = 165;

// bool meetsRequirement = actualWorkedHours >= requiredHours;
bool meetsRequirement = requiredHours <= actualWorkedHours;

Console.WriteLine("Requirement Met: " + meetsRequirement);

Console.WriteLine("\n::::::::: Coupon Validation :::::::::\n");


string enteredPromoCode = "SAVE10";
string appliedPromoCode = "SAVE20";

bool isInvalidPromo = enteredPromoCode != appliedPromoCode;

Console.WriteLine("Promo Invalid? :  " + isInvalidPromo);


int totalOrders = 25;
int minimumOrdersForBonus = 20;

bool qualifiesForBonus = totalOrders >= minimumOrdersForBonus;

// Evaluation steps:

//   • Evaluate the left operand expression.
//   • Evaluate the right operand expression.
//   • Apply the comparison operator.
//   • Produce a bool result.
//   • Assign the result (if part of an assignment).


// Key Rules
//   • Comparison operators always return bool.
//   • They do not modify values.
//   • Both sides must be comparable types.
//   • Precision matters when comparing numeric types.

// Common Mistakes
//   • Confusing = with ==.
//   • Comparing floating-point numbers without understanding precision.
//   • Assuming comparison changes variable value.


// Comparison operators allow you to:

//   • Validate payments
//   • Enforce limits
//   • Check requirements
//   • Drive logical decisions
//   • They transform numeric values into boolean decisions.
