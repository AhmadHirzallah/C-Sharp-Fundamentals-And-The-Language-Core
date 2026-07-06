Console.WriteLine("\n::::::::: Deposit Transaction :::::::::\n");

decimal accountBalance = 5000.00m;
decimal depositAmount = 1200.00M; //! القيمة المودعة

Console.WriteLine($"Balance Before: ${accountBalance}");

//! - (accountBalance + depositAmount) ->
//!		1. The right side is evaluated first, resulting in 6200.00 => 
//!		2. The result is then stored in the variable [[accountBalance]], replacing the previous value of 5000.00.
//? - We can use [Compound Assignment Operator (`+=`)]
accountBalance = accountBalance + depositAmount;
Console.WriteLine($"Balance After: ${accountBalance}");


#region Compound Assignment Operators

Console.WriteLine("\n\n\n::::::::: Inventory Update :::::::::\n");

int availableUnits = 50;
int soldUnitsByCustomer = 8;

availableUnits -= soldUnitsByCustomer; //! (availableUnits - soldUnitsByCustomer) -> 50 - 8 = 42
Console.WriteLine($"Available Units After Sale: {availableUnits}");


#endregion


//! ------------ Rules


int totalOrders = 10;
totalOrders = totalOrders + 5;

Console.WriteLine("Remaining Units: " + availableUnits);

//! Execution steps:
//*    • Read totalOrders (10)
//*    • Add 5 → result 15
//*    • Store 15 into totalOrders

//! Key Rules
//*    • = stores a value in a variable.
//*    • Right side is evaluated first.
//*    • Assignment replaces the previous value.
//*    • [Compound operators like ([[+= ...]] ||| [[-= ..]]. ||| [[*= ...]] ||| [[/= ...]] ||| [[%= ...]])] will
//*			simplify update logic.

//! Common Mistakes
//*    • Thinking = means equality comparison.
//*    • Forgetting that old value gets replaced.
//*    • Writing redundant long-form updates instead of compound operators.