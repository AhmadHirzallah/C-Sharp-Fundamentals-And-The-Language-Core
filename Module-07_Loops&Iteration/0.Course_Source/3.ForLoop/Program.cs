// Console.WriteLine(":::::::::::::::::: Basic Usage :::::::::::::::::::::::::");

// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }

Console.WriteLine("====== Phone Installment Plan ======");

decimal phonePrice = 1_200.00m;
decimal downPayment = 400.00m;
decimal monthlyPayment = 80.00m;

decimal balance = phonePrice - downPayment;


Console.WriteLine($"Phone Price    : $" + phonePrice);
Console.WriteLine($"Down Payment   : $" + downPayment);
Console.WriteLine($"Monthly Payment: $" + monthlyPayment);
Console.WriteLine($"Amount Financed: $" + balance);
Console.WriteLine("------------------------------------------");

for (int month = 1; balance > 0; month++)
{
    decimal paid = balance >= monthlyPayment ? monthlyPayment : balance; // 120 -> 100, 80 -> 80

    balance -= paid;

    string status = balance == 0 ? " PAID OFF" : "";

    Console.WriteLine("Month " + month + " | Paid: $" + paid + " | Remaining: $" + balance + status);
}
Console.WriteLine("------------------------------------------");
Console.WriteLine("Phone is yours. Enjoy it!");