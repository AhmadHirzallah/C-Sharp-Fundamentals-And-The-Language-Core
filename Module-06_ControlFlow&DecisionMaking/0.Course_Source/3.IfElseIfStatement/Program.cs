Console.WriteLine(":::::::::::::::: APPLY DISCOUNT :::::::::::::::::\n");

decimal orderAmount = 1500m;
decimal discountRate = 0m;
string discountLabel = "";


if (orderAmount >= 2000m)
{
    discountRate = 0.20m;
    discountLabel = "20% discount";
}
else if (orderAmount >= 1000m)
{
    discountRate = 0.10m;
    discountLabel = "10% discount";
}
else
{
    discountRate = 0m;
    discountLabel = "No discount";
}

decimal discountAmount = orderAmount * discountRate;

decimal finalAmount = orderAmount - discountAmount;

Console.WriteLine("--------------- BILL SUMMARY ---------------");
Console.WriteLine("Order Amount     : $" + orderAmount);
Console.WriteLine("Discount Applied : " + discountLabel);
Console.WriteLine("Discount Amount  : -$" + discountAmount);
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Final Amount     : $" + finalAmount);
Console.WriteLine("--------------------------------------------");