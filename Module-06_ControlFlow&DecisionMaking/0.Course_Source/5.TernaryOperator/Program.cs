bool isPremiumCustomer = true;

decimal discountRate = isPremiumCustomer ? 0.15m : 0.05m;

Console.WriteLine("Discount Rate: " + discountRate);