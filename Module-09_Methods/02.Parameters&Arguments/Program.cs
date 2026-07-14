int hoursWorked = 160;
decimal hourlyRate = 30m;

decimal salary = CalculateSalary(hoursWorked, hourlyRate);

Console.WriteLine("Salary: $" + salary);

decimal CalculateSalary(int hoursWorked, decimal hourlyRate)
{
	//! PARAMETERS: placeholders defined in the method signature

	decimal totalSalary = hoursWorked * hourlyRate;
	return totalSalary;
}

decimal price = 160;
decimal tax = .30m;

//! ARGUMENTS: values passed to the method when calling it
// decimal totalPrice = CalculateTotalPrice(tax, price); //* Wrong order (logical) no compile error (cause same datatype)
decimal totalPrice = CalculateTotalPrice(price, tax);

Console.WriteLine("Total Price: $" + totalPrice);


decimal CalculateTotalPrice(decimal price, decimal tax)
{
	var taxAmount = tax * price;
	var finalPrice = price + taxAmount;
	return finalPrice;
}