
#region Example-Case-1:

Console.WriteLine(":::::::::::::::: Make Payment :::::::::::::::::");

string userPaymentMethod = "Credit";

switch (userPaymentMethod)
{
	case "Cash":
		Console.WriteLine("You have selected Cash as your payment method.");
		break; //! If you remove [[break;]] ==>> Compile-Time ERROR: Control cannot fall through from one case label ('case "Cash":') to another

	case "Debit":
		Console.WriteLine("You have selected Debit card as your payment method.");
		break;

	case "Credit":
		Console.WriteLine("You have selected Credit card as your payment method.");
		break;

	case "Cheque":
		Console.WriteLine("You have selected Cheque as your payment method.");
		break;

	case "MoneyTransfer":
		Console.WriteLine("You have selected Money transfer as your payment method.");
		break;

	default:
		Console.WriteLine("Invalid/Unsupported payment method selected.");
		break;
}

#endregion Example-Case-1




#region Example-Case-2: Grouping Cases -> Combining multiple cases together.

Console.WriteLine("\n\n\n:::::::::::: Check Order ::::::::::::");

string orderStatus = "Returned";

switch (orderStatus)
{
	case "Pending":
		Console.WriteLine("Order is waiting for processing.");
		break;

	case "Shipped":
		Console.WriteLine("Order is on the way.");
		break;

	case "Delivered":
		Console.WriteLine("Order completed and delivered successfully.");
		break;

	case "Cancelled":
	case "Returned":
		Console.WriteLine("Order is closed because it is {Cancelled or Returned} and no further action is required.");
		break;

	default:
		Console.WriteLine("Unknown order status.");
		break;
}

#endregion Example-Case-2: Grouping Cases -> Combining multiple cases together.