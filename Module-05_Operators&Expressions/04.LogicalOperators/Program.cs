#region Logical AND (&&)

Console.WriteLine("\n::::::::: Loan Approval - Logical AND (&&) :::::::::\n");

//! التقييم على مستوى بطاقات الإئتمان
int personCreditScore = 720;
decimal personAnnualIncome = 60000.00m;
const int minimumGoodCreditScore = 700;
const decimal minimumLoanAnnualIncome = 50000.00m;

//! لكي تكون مؤهل من أجل أخذ قرض بالتالي:
bool doesPersonHasGoodCredit = personCreditScore >= minimumGoodCreditScore;
bool doesPersonHasSufficientIncome = personAnnualIncome >= minimumLoanAnnualIncome;

bool isLoanApproved = doesPersonHasGoodCredit && doesPersonHasSufficientIncome;

Console.WriteLine($"{nameof(doesPersonHasGoodCredit)}: {doesPersonHasGoodCredit}" +
	$"\n{nameof(doesPersonHasSufficientIncome)}: {doesPersonHasSufficientIncome}" +
	$"\nResult => {nameof(isLoanApproved)}: {isLoanApproved}");


#endregion

#region Logical AND (&)

Console.WriteLine("\n\n\n::::::::: Loan Approval - Logical AND (&) :::::::::\n");

//! التقييم على مستوى بطاقات الإئتمان
int personCreditScore2 = 520;
decimal personAnnualIncome2 = 60000.00m;
const int minimumGoodCreditScore2 = 700;
const decimal minimumLoanAnnualIncome2 = 50000.00m;

//! لكي تكون مؤهل من أجل أخذ قرض بالتالي:
bool doesPersonHasGoodCredit2 = personCreditScore2 >= minimumGoodCreditScore2;
bool doesPersonHasSufficientIncome2 = personAnnualIncome2 >= minimumLoanAnnualIncome2;

Console.WriteLine($"doesPersonHasGoodCredit2 & doesPersonHasSufficientIncome2 => " +
	$"This will evaluate both conditions even if the first one is false." +
	$"\n\nConclusion: [&] always evaluates both sides and never short-circuits.\n");
bool isLoanApproved2 = doesPersonHasGoodCredit2 & doesPersonHasSufficientIncome2;

Console.WriteLine($"{nameof(doesPersonHasGoodCredit2)}: {doesPersonHasGoodCredit2}" +
	$"\n{nameof(doesPersonHasSufficientIncome2)}: {doesPersonHasSufficientIncome2}" +
	$"\nResult => {nameof(isLoanApproved2)}: {isLoanApproved2}");


#endregion

#region Logical OR (||)

Console.WriteLine("\n\n::::::::: Discount Eligibility - Logical OR (||) :::::::::\n");

const int requiredLoyalityPointsForDiscount = 1000;

int personLoyalityPoints = 1200;
bool doesPersonHasPromoCode = false;

bool isPersonEligibleForDiscount = (personLoyalityPoints >= requiredLoyalityPointsForDiscount) || doesPersonHasPromoCode;
Console.WriteLine($"{nameof(personLoyalityPoints)}: {personLoyalityPoints}" +
	$"\n{nameof(doesPersonHasPromoCode)}: {doesPersonHasPromoCode}" +
	$"\nResult => {nameof(isPersonEligibleForDiscount)}: {isPersonEligibleForDiscount}");

#endregion



#region Negation [!] => [!False] becomes [True] ---- AND ---- [!True] becomes [False]

Console.WriteLine("\n\n\n::::::::: Account Status - Negation [!] :::::::::\n");
bool isUserAccountActive = false;
bool isUserAccountBlocked = !isUserAccountActive;
Console.WriteLine($"{nameof(isUserAccountActive)}: {isUserAccountActive}" +
	$"\n{nameof(isUserAccountBlocked)}: {isUserAccountBlocked}");

#endregion

#region Logical [XOR] - [^]

Console.WriteLine("\n\n\n=== TAX RESIDENCY DECLARATION VALIDATION -- Logical [XOR] - [^] ===\n");

bool isUSA_TaxResident = true;
bool isNonUSA_TaxResident = false;

bool isValidDeclaration = isUSA_TaxResident ^ isNonUSA_TaxResident;

Console.WriteLine($"{nameof(isUSA_TaxResident)}: {isUSA_TaxResident}" +
	$"\n{nameof(isNonUSA_TaxResident)}: {isNonUSA_TaxResident}" +
	$"\n``` bool isValidDeclaration = isUSA_TaxResident ^ isNonUSA_TaxResident ``` => Result Below:" +
	$"\n\t\t{nameof(isValidDeclaration)}: {isValidDeclaration}");

#endregion


//! NOTES:

//!	 Evaluation rules:
//*		   • Expressions are evaluated left to right.
//*		   • && stops early if the first condition is false.
//*		   • || stops early if the first condition is true.
//*		   • & always evaluates both sides.
//*		   • | always evaluates both sides.
//*		   • ^ evaluates both sides and returns true only if exactly one side is true.
//*		   • ! evaluates the operand then flips the result.

//!	 Key Rules
//*		   • Logical operators work only with boolean values.
//*		   • They do not modify variables.
//*		   • They combine or invert logical results.
//*		   • Short-circuit behavior affects evaluation flow.
