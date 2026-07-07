
decimal productTotalPrice = 200.00m;
decimal productDiscountRate = 0.10m;
decimal productTaxRate = 0.05m;


Console.WriteLine("\n\n\n::::::::: Discount Calculation - NOT CLEAN EXAMPLE :::::::::\n");

decimal productFinalPrice_NotClean = productTotalPrice - productTotalPrice * productDiscountRate + productTotalPrice * productTaxRate;
Console.WriteLine($"VERY VERY BAD! Even if the precedence is correct, the calculation is [[complex]] & [[not clean]] & misleading.\n" +
	$"\nCode:\n\t\tdecimal productFinalPrice = productTotalPrice - productTotalPrice * productDiscountRate + productTotalPrice * productTaxRate" +
	$"\n\n{nameof(productTotalPrice)} = {productTotalPrice}\n" +
	$"{nameof(productDiscountRate)} = {productDiscountRate}\n" +
	$"{nameof(productTaxRate)} = {productTaxRate}\n" +
	$"{nameof(productFinalPrice_NotClean)} = {productFinalPrice_NotClean}\n");



Console.WriteLine("\n\n\n\n\n::::::::: Discount Calculation - CLEAR CODE EXAMPLE :::::::::\n");

decimal productFinalPrice_MoreClean = productTotalPrice + (-(productTotalPrice * productDiscountRate) + (productTotalPrice * productTaxRate));
Console.WriteLine($"\nMore Clean & Organized! Even if the precedence is correct, Adding of (Parenthesis) make operations more clear to read.\n" +
	$"\nCode:\n\t\tdecimal productFinalPrice_MoreClean = productTotalPrice + (-(productTotalPrice * productDiscountRate) + (productTotalPrice * productTaxRate));" +
	$"\n\n{nameof(productTotalPrice)} = {productTotalPrice}\n" +
	$"{nameof(productDiscountRate)} = {productDiscountRate}\n" +
	$"{nameof(productTaxRate)} = {productTaxRate}\n" +
	$"{nameof(productFinalPrice_MoreClean)} = {productFinalPrice_MoreClean}\n");



Console.WriteLine("\n\n\n\n\n::::::::: Discount Calculation - BEST CLEAR & CLEAN & PROFESSIONAL :::::::::\n");

decimal discountPrice = productTotalPrice * productDiscountRate;
decimal taxAmount = productTotalPrice * productTaxRate;
decimal finalAmount = productTotalPrice - discountPrice + taxAmount;
Console.WriteLine($"\nBEST CLEAN && CLEAR CODE & BEST ORGANIZATION! Adding variables for intermediate calculations makes the code more readable and maintainable.\n" +
	$"\nCode:\n\t\tdecimal discountPrice = productTotalPrice * productDiscountRate;\n\t\tdecimal taxAmount = productTotalPrice * productTaxRate;\n\t\tdecimal finalAmount = productTotalPrice - discountPrice + taxAmount;" +
	$"\n\n{nameof(productTotalPrice)} = {productTotalPrice}\n" +
	$"{nameof(productDiscountRate)} = {productDiscountRate}\n" +
	$"{nameof(productTaxRate)} = {productTaxRate}\n" +
	$"{nameof(discountPrice)} = {discountPrice}\n" +
	$"{nameof(taxAmount)} = {taxAmount}\n" +
	$"{nameof(finalAmount)} = {finalAmount}\n");



Console.WriteLine($"\n\n\n\n ======================= NOTES =========================\n\n\n" +
	$"Evaluation Direction\r\n   • When operators have the same precedence level:\r\n   • They are evaluated from left to right.\r\n Key Rules\r\n   • Operators have fixed precedence rules.\r\n   • Parentheses override precedence.\r\n   • Same-level operators evaluate left to right.\r\n   • Clear code is better than clever code.\r\n Common Mistakes\r\n   • Assuming expressions execute left to right without precedence.\r\n   • Writing complex expressions without parentheses.\r\n   • Ignoring readability in financial calculations.");

//! Evaluation Direction
//*    • When operators have the same precedence level:
//*    • They are evaluated from left to right.
//!  Key Rules
//*    • Operators have fixed precedence rules.
//*    • Parentheses override precedence.
//*    • Same-level operators evaluate left to right.
//*    • Clear code is better than clever code.
//!  Common Mistakes
//*    • Assuming expressions execute left to right without precedence.
//*    • Writing complex expressions without parentheses.
//*    • Ignoring readability in financial calculations.


