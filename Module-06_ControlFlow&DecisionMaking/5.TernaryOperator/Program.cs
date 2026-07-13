
bool isCustomerPremium = true;

const decimal PremiumDiscountRate = 0.15m;
const decimal RegularCustomerDiscountRate = 0.05m;

decimal discountRate = isCustomerPremium ? PremiumDiscountRate : RegularCustomerDiscountRate;

Console.WriteLine($"Customer {(isCustomerPremium ? "is" : "is not")} a premium member" +
	$"\nDiscount Rate: {discountRate:P}");