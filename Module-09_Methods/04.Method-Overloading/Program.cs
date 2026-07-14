internal class Program
{
	private static void Main(string[] args)
	{
		//ShowMultipleSalaryOverloadsProgram();
		ShowMultiplePaymentMethodsOverloadsProgram();
	}

	#region Program 1 - ShowMultipleSalaryOverloadsProgram

	private static void ShowMultipleSalaryOverloadsProgram()
	{
		decimal pay1 = CalculatePay(50000m);
		decimal pay2 = CalculatePay(50000m, 5000m);
		decimal pay3 = CalculatePay(50000m, 5000m, 3000);

		Console.WriteLine($"Pay 1: ${pay1:F2}" +
			$"\nPay 2: ${pay2:F2}" +
			$"\nPay 3: ${pay3:F2}");
	}

	private static decimal CalculatePay(decimal salary)
	{
		return salary;
	}

	private static decimal CalculatePay(decimal salary, decimal bonus)
	{
		return salary + bonus;
	}

	private static decimal CalculatePay(decimal salary, decimal bonus, decimal tax)
	{
		return salary + bonus - tax;
	}

	#endregion Program 1 - ShowMultipleSalaryOverloadsProgram


	#region Program 2 - ShowMultiplePaymentMethodsOverloadsProgram


	private static void ShowMultiplePaymentMethodsOverloadsProgram()
	{
		var visaPayment = new VisaPayment
		{
			CardPin = "1234",
			CardPassword = "password123"
		};

		var paypalPayment = new PaypalPayment
		{
			AccountEmail = "user@example.com",
			AccountPassword = "paypalpassword"
		};

		var clickBankPayment = new ClickBankPayment
		{
			ClickAccountIdentifier = "clickbank123",
			AliasName = "myalias"
		};


		Console.WriteLine("\n\nOverloaded Method Calls:");
		ProcessPayment(visaPayment);
		ProcessPayment(paypalPayment);
		ProcessPayment(clickBankPayment);
	}

	private static void ProcessPayment(VisaPayment visaPayment)
	{
		Console.WriteLine($"Processing Visa payment for card ending in {visaPayment.CardPin.Substring(visaPayment.CardPin.Length - 4)}");
	}

	private static void ProcessPayment(PaypalPayment paypalPayment)
	{
		Console.WriteLine($"Processing PayPal payment for account {paypalPayment.AccountEmail}");
	}

	private static void ProcessPayment(ClickBankPayment clickBankPayment)
	{
		Console.WriteLine($"Processing ClickBank payment for account {clickBankPayment.ClickAccountIdentifier}");
	}


	public class VisaPayment
	{
		public string CardPin { get; set; }
		public string CardPassword { get; set; }

	}

	public class PaypalPayment
	{
		public string AccountEmail { get; set; }
		public string AccountPassword { get; set; }
	}

	public class ClickBankPayment
	{
		public string ClickAccountIdentifier { get; set; }
		public string AliasName { get; set; }

	}

	#endregion Program 2 - ShowMultiplePaymentMethodsOverloadsProgram


}