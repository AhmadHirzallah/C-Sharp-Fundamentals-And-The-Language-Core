using System.Runtime.Intrinsics.X86;

Console.WriteLine("\n::::::::: Deposit Transaction :::::::::\n");

decimal accountBalance = 5000.00m;
decimal depositAmount = 1200.00m;

accountBalance = accountBalance + d epositAmount;

Console.WriteLine("Updated Balance: $" + accountBalance);

Console.WriteLine("\n::::::::: Inventory Update :::::::::\n");

int availableUnits = 50;
int soldUnits = 8;

availableUnits -= soldUnits;

Console.WriteLine("Remaining Units: " + availableUnits);




int totalOrders = 10;
totalOrders = totalOrders + 5;

Console.WriteLine("Remaining Units: " + availableUnits);

// Execution steps:
//    • Read totalOrders (10)
//    • Add 5 → result 15
//    • Store 15 into totalOrders

// Key Rules
//    • = stores a value in a variable.
//    • Right side is evaluated first.
//    • Assignment replaces the previous value.
//    • Compound operators simplify update logic.

// Common Mistakes
//    • Thinking = means equality comparison.
//    • Forgetting that old value gets replaced.
//    • Writing redundant long-form updates instead of compound operators.