var productPrice = 1500m;
var quantity = 2;

//! Compile time error: Cannot implicitly convert type 'void' to 'decimal'
//var variable = ProcessInvoice(productPrice, quantity);
//* This is method we create because
//*		- we wany an entry point to process the invoice && our usecase/feature
//! void => no return type.
ProcessInvoice(productPrice, quantity);





void ProcessInvoice(decimal price, int quantity)
{
	var total = CalculateTotal(price, quantity);

	// Print
	Console.WriteLine("------ Total: ------");
	Console.WriteLine("Total: $" + total);
}

decimal CalculateTotal(decimal price, int quantity)
{
	// Subtotal
	var subtotal = CalculateSubtotal(price, quantity);

	// discount
	var discountAmount = CalculateDiscount(subtotal, quantity);


	// Final total
	return subtotal - discountAmount;
}

decimal CalculateSubtotal(decimal price, int quantity)
{
	return price * quantity;
}

decimal CalculateDiscount(decimal subtotal, int quantity)
{
	// Calculate discount
	const decimal discountRate = 0.10m;

	return IsDiscountApplicable(quantity) ? subtotal * discountRate : 0m;
}

bool IsDiscountApplicable(int quantity)
{
	return quantity >= 2;
}
