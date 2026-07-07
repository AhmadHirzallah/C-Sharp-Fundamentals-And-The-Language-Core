Console.WriteLine("\n::::::::: Loan Approval :::::::::\n");

int creditScore = 720;
decimal annualIncome = 60000.00m;

bool hasGoodCredit = creditScore >= 700;
bool hasSufficientIncome = annualIncome >= 50000.00m;

bool loanApproved = hasGoodCredit && hasSufficientIncome;

Console.WriteLine("Loan Approved: " + loanApproved);

Console.WriteLine("\n::::::::: Loan Approval #2 :::::::::\n");

int creditScore1 = 520;
decimal annualIncome1 = 60000.00m;

bool hasGoodCredit1 = creditScore1 >= 700;
bool hasSufficientIncome1 = annualIncome1 >= 50000.00m;

bool loanApproved1 = hasGoodCredit1 & hasSufficientIncome1; // Always evaluates both sides even if hasGoodCredit1 is false

Console.WriteLine("Loan Approved: " + loanApproved1);

Console.WriteLine("\n::::::::: Discount Eligibility :::::::::\n");

int loyaltyPoints = 1200;
bool hasPromoCode = false;

bool qualifiesForDiscount = loyaltyPoints >= 1000 || hasPromoCode;

Console.WriteLine("Qualifies For Discount: " + qualifiesForDiscount);

Console.WriteLine("\n::::::::: Account Status :::::::::\n");

bool isAccountActive = false;

bool isAccountBlocked = !isAccountActive;

Console.WriteLine("Account Blocked: " + isAccountBlocked);


Console.WriteLine("=== TAX RESIDENCY DECLARATION VALIDATION ===\n");

bool isUsTaxResident = true;
bool isNonUsTaxResident = false;

bool isValidDeclaration = isUsTaxResident ^ isNonUsTaxResident;

Console.WriteLine("Declaration Valid   : " + isValidDeclaration);

// Evaluation rules:

//   • Expressions are evaluated left to right.
//   • && stops early if the first condition is false.
//   • || stops early if the first condition is true.
//   • & always evaluates both sides.
//   • | always evaluates both sides.
//   • ^ evaluates both sides and returns true only if exactly one side is true.
//   • ! evaluates the operand then flips the result.


// Key Rules

//   • Logical operators work only with boolean values.
//   • They do not modify variables.
//   • They combine or invert logical results.
//   • Short-circuit behavior affects evaluation flow.
