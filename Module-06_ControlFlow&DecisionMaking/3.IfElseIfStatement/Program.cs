#region Ok; Not bad approach; but their is better one [better achieved by removing the (else) and using of default values]!.
{
	Console.WriteLine(":::::::::::::::: APPLY DISCOUNT - [3 Conditions] :::::::::::::::::\n");

	decimal orderAmount = 700.00m;
	//decimal orderAmount = 1500.00m;
	//decimal orderAmount = 2500.00m;
	decimal discountRate = 0.00m;

	string currentDiscountLabel = string.Empty;
	const string DiscountBestLabel_20 = "20% discount  :-)";
	const string DiscountIntermediateLabel_10 = "10% discount  :-)";
	const string DiscountWorstLabel_0 = "NO DISCOUNT  -.- ";

	//! Conditions:
	if (orderAmount >= 2000m)
	{
		discountRate = 0.20m;
		currentDiscountLabel = DiscountBestLabel_20;
	}
	else if (orderAmount >= 1000M)
	{
		discountRate = 0.10m;
		currentDiscountLabel = DiscountIntermediateLabel_10;
	}
	else
	{
		discountRate = 0.00m;
		currentDiscountLabel = DiscountWorstLabel_0;
	}

	//! Clean Code Approach - No Complex Calculations && use more variables && Divide AND Conquer for better readability:
	decimal discountAmount = orderAmount * discountRate;
	decimal finalAmount = orderAmount - discountAmount;

	Console.WriteLine($" ---------------- BILL SUMMARY ----------------\n" +
		$"Order Amount\t\t\t\t: {orderAmount:C}\n" +
		$"Discount Applied Type\t\t\t: {currentDiscountLabel}\n" +
		$"Discount Applied Amount\t\t\t: {discountAmount:C}\n" +
		$"------------------------------------------------------------\n" +
		$"Final Amount\t\t\t\t: {finalAmount:C}\n" +
		$"------------------------------------------------------------\n");

}

#endregion Ok; Not bad approach; but their is better one [better achieved by removing the (else) and using of default values]!.



#region Best Prof. Approach - Better is achieved by removing the (else) and using of default values]!.

{
	Console.WriteLine("\n\n\n:::::::::::::::: APPLY DISCOUNT - [ 2 Conditions :-) ] :::::::::::::::::\n");

	decimal orderAmount = 700.00m;
	//decimal orderAmount = 1500.00m;
	//decimal orderAmount = 2500.00m;
	decimal discountRate = 0.00m;

	const string DiscountBestLabel_20 = "20% discount  :-)";
	const string DiscountIntermediateLabel_10 = "10% discount  :-)";
	const string DiscountWorstLabel_0 = "NO DISCOUNT  -.- ";

	//! Default Value => So we remove the (else) and use of default values!
	//?  Note that [[discountRate]] is also initialized to 0.00m (Which is default && it is needed & used in [[else]], so we can remove the [[else]] and use of default values)!
	string currentDiscountLabel = DiscountWorstLabel_0;

	//! Conditions:
	if (orderAmount >= 2000m)
	{
		discountRate = 0.20m;
		currentDiscountLabel = DiscountBestLabel_20;
	}
	else if (orderAmount >= 1000M)
	{
		discountRate = 0.10m;
		currentDiscountLabel = DiscountIntermediateLabel_10;
	}
	//! No need for [[else]] block, ==>> because we have already initialized the [[discountRate]] to 0.00m and [[currentDiscountLabel]] to DiscountWorstLabel_0
	//else
	//{
	//	discountRate = 0.00m;
	//	currentDiscountLabel = DiscountWorstLabel_0;
	//}

	//! Clean Code Approach - No Complex Calculations && use more variables && Divide AND Conquer for better readability:
	decimal discountAmount = orderAmount * discountRate;
	decimal finalAmount = orderAmount - discountAmount;

	Console.WriteLine($" ---------------- BILL SUMMARY ----------------\n" +
		$"Order Amount\t\t\t\t: {orderAmount:C}\n" +
		$"Discount Applied Type\t\t\t: {currentDiscountLabel}\n" +
		$"Discount Applied Amount\t\t\t: {discountAmount:C}\n" +
		$"------------------------------------------------------------\n" +
		$"Final Amount\t\t\t\t: {finalAmount:C}\n" +
		$"------------------------------------------------------------\n");

}
#endregion Best Prof. Approach - Better is achieved by removing the (else) and using of default values]!.