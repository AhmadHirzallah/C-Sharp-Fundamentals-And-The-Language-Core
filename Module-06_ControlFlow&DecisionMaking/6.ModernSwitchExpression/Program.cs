#region Example-1 (Main for Run)

var order = new Order { Id = 1, CustomerName = "Ahmad Hirzallah", Amount = 100.50m, Status = OrderStatus.Rejected };
var order2 = new Order { Id = 2, CustomerName = "Ahmad Hirzallah22222", Amount = 101230.51230m, Status = OrderStatus.Approved };

Console.WriteLine(":::::::::::::::::::: TRADITIONAL SWITCH ::::::::::::::::::::\n");
Console.WriteLine($"--------------------------------" +
	$"\nOrder #{order.Id} -> {GetOrderStatusTraditionSwitch(order)}");

Console.WriteLine($"\n\n--------------------------------" +
	$"\nOrder #{order2.Id} -> {GetOrderStatusTraditionSwitch(order2)}");


Console.WriteLine("\n\n\n\n:::::::::::::::::::: Modern C# SWITCH Expression ::::::::::::::::::::\n");

Console.WriteLine($"--------------------------------" +
	$"\nOrder #{order.Id} -> {GetOrderStatusSwitchExpression(order)}");

Console.WriteLine($"\n\n--------------------------------" +
	$"\nOrder #{order2.Id} -> {GetOrderStatusSwitchExpression(order2)}");

#endregion Example-1


#region Example-2  (Main for Run)

{
	Console.WriteLine("\n\n\n\n:::::::::::::::::::: Modern C# SWITCH Expression ([[\tRelational Pattern\t]]) ::::::::::::::::::::\n");

	//! Order class is from Example-1
	Order[] orders = new Order[]
	{
	new Order { Id = 1, CustomerName = "Ahmad Hirzallah", Amount = 100.50m, Status = OrderStatus.Rejected },
	new Order { Id = 2, CustomerName = "Ahmad Hirzallah22222", Amount = 500.51230m, Status = OrderStatus.Approved },
	new Order { Id = 3, CustomerName = "Ahmad Hirzallah33333", Amount = 700.50m, Status = OrderStatus.Pending },
	new Order { Id = 4, CustomerName = "Ahmad Hirzallah44444", Amount = 1000.51230m, Status = OrderStatus.InShiping },
	new Order { Id = 5, CustomerName = "Ahmad Hirzallah55555", Amount = 1500.50m, Status = OrderStatus.Delivered },
	new Order { Id = 6, CustomerName = "Ahmad Hirzallah66666", Amount = 2000.51230m, Status = OrderStatus.Cancelled },
	new Order { Id = 7, CustomerName = "Ahmad Hirzallah77777", Amount = 3000.50m, Status = OrderStatus.Returned }
	};

	foreach (var orderObj in orders)
	{
		string orderSizeCategory = orderObj.Amount switch
		{
			>= 2000 => "Large Order",
			>= 1000 => "Medium Order",
			>= 500 => "Small Order",
			_ => "Very Small Order",
		};

		Console.WriteLine($"Order #{orderObj.Id} => Amount: {orderObj.Amount} => {orderSizeCategory}");
	}
}

#endregion


#region Example-3  (Main for Run)
{
	Console.WriteLine("\n\n\n\n:::::::::::::::::::: Modern C# SWITCH Expression ([[\tLogical Pattern (AND)\t]]) ::::::::::::::::::::\n");
	//! Order class is from Example-1
	Order[] orders = new Order[]
	{
	new Order { Id = 1, CustomerName = "Ahmad Hirzallah", Amount = 100.50m, Status = OrderStatus.Rejected },
	new Order { Id = 2, CustomerName = "Ahmad Hirzallah22222", Amount = 500.51230m, Status = OrderStatus.Approved },
	new Order { Id = 3, CustomerName = "Ahmad Hirzallah33333", Amount = 700.50m, Status = OrderStatus.Pending },
	new Order { Id = 4, CustomerName = "Ahmad Hirzallah44444", Amount = 1000.51230m, Status = OrderStatus.InShiping },
	new Order { Id = 5, CustomerName = "Ahmad Hirzallah55555", Amount = 1500.50m, Status = OrderStatus.Delivered },
	new Order { Id = 6, CustomerName = "Ahmad Hirzallah66666", Amount = 2000.51230m, Status = OrderStatus.Cancelled },
	new Order { Id = 7, CustomerName = "Ahmad Hirzallah77777", Amount = 3000.50m, Status = OrderStatus.Returned },
	new Order { Id = 8, CustomerName = "Ahmad Hirzallah88888", Amount = 3000.50m, Status = OrderStatus.Approved },
	};

	foreach (var orderObj in orders)
	{
		string result = orderObj switch
		{
			{ Status: OrderStatus.Pending } => $"Order #{orderObj.Id} is [[pending]] and waiting for processing.",
			{ Status: OrderStatus.Approved, Amount: > 2000 } => $"Order #{orderObj.Id} is a [[[LARGE]]] [[approved]] and will be processed soon.",
			{ Status: OrderStatus.Approved } => $"Order #{orderObj.Id} is [[approved]] and will be processed soon.",
			{ Status: OrderStatus.InShiping } => $"Order #{orderObj.Id} is [[in shipping]] and on the way.",
			{ Status: OrderStatus.Delivered } => $"Order #{orderObj.Id} is [[delivered]] and completed successfully.",
			{ Status: OrderStatus.Cancelled or OrderStatus.Rejected or OrderStatus.Returned } => $"Order #{orderObj.Id} is [[closed]] and no further action is required.",
		};

		Console.WriteLine($"{result}");
	}

}
#endregion


#region  Methods & Classes & Enums  

string GetOrderStatusTraditionSwitch(Order order)
{
	string orderStatusMessage = string.Empty;

	switch (order.Status)
	{
		case OrderStatus.Pending:
			orderStatusMessage = "Order is [[pending]] and waiting for processing.";
			break;

		case OrderStatus.Approved:
			orderStatusMessage = "Order is [[approved]] and will be processed soon.";
			break;

		case OrderStatus.InShiping:
			orderStatusMessage = "Order is [[in shipping]] and on the way.";
			break;

		case OrderStatus.Delivered:
			orderStatusMessage = "Order is [[delivered]] and completed successfully.";
			break;

		case OrderStatus.Rejected:
		case OrderStatus.Cancelled:
		case OrderStatus.Returned:
			orderStatusMessage = "Order is [[closed]] and no further action is required.";
			break;

		default:
			orderStatusMessage = "Unknown order status.";
			break;
	}

	return orderStatusMessage;
}

string GetOrderStatusSwitchExpression(Order order)
{
	string orderStatusMessage = string.Empty;

	orderStatusMessage = order.Status switch
	{
		OrderStatus.Pending => "Order is [[pending]] and waiting for processing.",
		OrderStatus.Approved => "Order is [[approved]] and will be processed soon.",
		OrderStatus.InShiping => "Order is [[in shipping]] and on the way.",
		OrderStatus.Delivered => "Order is [[delivered]] and completed successfully.",
		OrderStatus.Cancelled or OrderStatus.Rejected or OrderStatus.Returned => "Order is [[closed]] and no further action is required.",
		_ => "Unknown order status."
	};

	return orderStatusMessage;
}

class Order
{
	public int Id { get; set; }
	public string CustomerName { get; set; } = string.Empty;
	public decimal Amount { get; set; }
	public OrderStatus Status { get; set; }
}

enum OrderStatus
{
	Pending,
	Approved,
	InShiping,
	Delivered,
	Cancelled,
	Rejected,
	Returned
}
#endregion