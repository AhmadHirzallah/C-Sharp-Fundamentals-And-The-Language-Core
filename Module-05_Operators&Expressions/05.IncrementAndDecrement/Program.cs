#region POST-INCREAMENT => [variableIdentifier++]

Console.WriteLine("\n::::::::: Ticket Counter :::::::::\n");

int issuedTicketsInTrainStation = 10;

//! previousCountInTrainStation = 10, issuedTicketsInTrainStation = 11
int previousCountInTrainStation = issuedTicketsInTrainStation++;

Console.WriteLine($"{nameof(previousCountInTrainStation)}: {previousCountInTrainStation}" +
	$"\n{nameof(issuedTicketsInTrainStation)}: {issuedTicketsInTrainStation}");

#endregion

#region PRE-INCREAMENT => [++variableIdentifier]

Console.WriteLine("\n\n\n::::::::: Order Processing :::::::::\n");

int processedOrdersInWarehouse = 15;

//! processedOrdersInWarehouse = 16, updatedProcessedOrdersInWarehouse = 16
int updatedProcessedOrdersInWarehouse = ++processedOrdersInWarehouse;

Console.WriteLine($"{nameof(processedOrdersInWarehouse)} = {processedOrdersInWarehouse}\n" +
	$"{nameof(updatedProcessedOrdersInWarehouse)} = {updatedProcessedOrdersInWarehouse}");

#endregion

#region POST-DECREMENT => [variableIdentifier--]

Console.WriteLine("\n\n\n::::::::: Inventory Reduction :::::::::\n");

int warehouseAvailableUnits = 5;

//! warehouseAvailableUnits = 4, unitsInWarehouseBeforeLastSale = 5
int unitsInWarehouseBeforeLastSale = warehouseAvailableUnits--;

Console.WriteLine($"{nameof(unitsInWarehouseBeforeLastSale)} = {unitsInWarehouseBeforeLastSale}\n" +
	$"{nameof(warehouseAvailableUnits)} = {warehouseAvailableUnits}");

#endregion

Console.WriteLine("\n\n\n---------------------------\nCheck Comment Notes:" +
	"// Where Increment and Decrement Are Commonly Used\r\n\r\n//   • Counting iterations\r\n//   • Tracking processed records\r\n//   • Managing sequential identifiers\r\n//   • Inventory adjustments\r\n\r\n// Key Rules\r\n\r\n//   • Only applicable to numeric types.\r\n//   • Always modify the variable.\r\n//   • Prefix modifies before returning value.\r\n//   • Postfix returns value before modifying.\r\n\r\n// Common Mistakes\r\n\r\n//   • Confusing prefix and postfix behavior.\r\n//   • Using increment inside complex expressions without understanding evaluation order.\r\n//   • Assuming both forms behave identically inside assignments.\r\n\r\n\r\n// Increment and decrement operators:\r\n\r\n//   • Modify numeric values by one\r\n//   • Support prefix and postfix forms\r\n//   • Affect expression evaluation order");


//! Where Increment and Decrement Are Commonly Used
//*		   • Counting iterations
//*		   • Tracking processed records
//*		   • Managing sequential identifiers
//*		   • Inventory adjustments

//! Key Rules
//*		   • Only applicable to numeric types.
//*		   • Always modify the variable.
//*		   • Prefix modifies before returning value.
//*		   • Postfix returns value before modifying.

//! Common Mistakes
//*		   • Confusing prefix and postfix behavior.
//*		   • Using increment inside complex expressions without understanding evaluation order.
//*		   • Assuming both forms behave identically inside assignments.


//! Increment and decrement operators:
//*		   • Modify numeric values by one
//*		   • Support prefix and postfix forms
//*		   • Affect expression evaluation order