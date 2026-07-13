Console.WriteLine("::::::::::::::::: BASIC :::::::::::::::::::");

for (int counter = 0; counter <= 10; counter++)
{
	Console.WriteLine($"Counter: {counter}");
}



Console.WriteLine("\n\n\n::::::::::::::::: Phone Installation Plan :::::::::::::::::::");

decimal phoneRealPrice = 1_200.00m;
decimal downPayment = 400.00m; //! الدفعة الأولية
decimal monthlyPayment = 100.00m; //! الدفعة الشهرية

decimal currentPaid = downPayment; //! المبلغ الإجمالي المدفوع
decimal cantidadRestante = phoneRealPrice - currentPaid; //! المبلغ المتبقي

Console.WriteLine($"\n\nPhone Real Price: {phoneRealPrice:C}\n" +
	$"Down Payment: {downPayment:C}\n" +
	$"Monthly Payment: {monthlyPayment:C}" +
	$"\nTotal Paid: {currentPaid:C}\n" +
	$"Remaining Amount: {cantidadRestante:C}\n\n");

string paymentStatus = string.Empty;

for (int month = 1; cantidadRestante > 0; month++)
{
	currentPaid = cantidadRestante >= monthlyPayment ? monthlyPayment : cantidadRestante;

	cantidadRestante -= currentPaid;
	Console.WriteLine($"You paid: {currentPaid:C} - month: {month}");

	paymentStatus = cantidadRestante == 0 ? "Paid in Full" : $"Pending {cantidadRestante:C}";

	Console.WriteLine($"Month {month}: {paymentStatus} -- remaining: {cantidadRestante:C}\n\n");
}


Console.WriteLine("------------------------\n" +
	$"Phone is yours! Enjoy it!");