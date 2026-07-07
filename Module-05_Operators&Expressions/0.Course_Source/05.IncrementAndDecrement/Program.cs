Console.WriteLine("\n::::::::: Ticket Counter :::::::::\n");

int issuedTickets = 10;

int previousCount = issuedTickets++;

Console.WriteLine("previousCount: " + previousCount); // 10
Console.WriteLine("Current Count: " + issuedTickets); // 11

Console.WriteLine("\n::::::::: Order Processing :::::::::\n");

int processedOrders = 10;

int updatedCount = ++processedOrders;

Console.WriteLine("Updated Count: " + updatedCount); // 11
Console.WriteLine("Current Count: " + processedOrders); // 11

Console.WriteLine("\n::::::::: Inventory Reduction :::::::::\n");

int availableUnits = 5;

int unitsBeforeSale = availableUnits--;


Console.WriteLine("Units Before Sale: " + unitsBeforeSale);
Console.WriteLine("Units After Sale: " + availableUnits);


// Where Increment and Decrement Are Commonly Used

//   • Counting iterations
//   • Tracking processed records
//   • Managing sequential identifiers
//   • Inventory adjustments

// Key Rules

//   • Only applicable to numeric types.
//   • Always modify the variable.
//   • Prefix modifies before returning value.
//   • Postfix returns value before modifying.

// Common Mistakes

//   • Confusing prefix and postfix behavior.
//   • Using increment inside complex expressions without understanding evaluation order.
//   • Assuming both forms behave identically inside assignments.


// Increment and decrement operators:

//   • Modify numeric values by one
//   • Support prefix and postfix forms
//   • Affect expression evaluation order