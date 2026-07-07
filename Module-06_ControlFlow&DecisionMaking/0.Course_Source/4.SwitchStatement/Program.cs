Console.WriteLine(":::::::::::::::: Make Payment :::::::::::::::::");

string paymentMethod = "Credit";


switch (paymentMethod)
{
    case "Cash":
        Console.WriteLine("Paid Cash");
        break;

    case "Debit":
        Console.WriteLine("Paid using Debit card.");
        break;

    case "Credit":
        Console.WriteLine("Paid using Credit card.");
        break;

    case "Cheque":
        Console.WriteLine("Paid using Cheque.");
        break;

    case "MoneyTransfer":
        Console.WriteLine("Paid using Money transfer.");
        break;

    default:
        Console.WriteLine("Unsupported payment method.");
        break;
}


Console.WriteLine(":::::::::::: Check Order ::::::::::::");

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
        Console.WriteLine("Order completed successfully.");
        break;
    case "Cancelled":
    case "Returned":
        Console.WriteLine("Order is closed and no further action is required.");
        break;

    default:
        Console.WriteLine("Unknown order status.");
        break;
}