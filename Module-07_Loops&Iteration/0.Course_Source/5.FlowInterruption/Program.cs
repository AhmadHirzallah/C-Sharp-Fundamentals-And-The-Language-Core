// Console.WriteLine(":::::::::::::::::: Basic Usage :::::::::::::::::::::::::");

// for (int i = 1; i <= 10; i++)
// {
//     if (i == 3)
//     {
//         continue;
//     }

//     if (i == 5)
//     {
//         break;
//     }

//     Console.WriteLine(i);
// }

Console.WriteLine(":::::::::::::::::: Daily Budget Tracker :::::::::::::::::::::::::");

decimal budget = 200;
decimal spent = 0;

while (true)
{
    decimal amount = Random.Shared.Next(5, 100);

    if (spent + amount > budget)
    {
        Console.WriteLine("Not enough budget! Stop");
        break;
    }

    spent += amount;

    Console.WriteLine("Purchased: $" + amount + " out of $" + budget);
}

Console.WriteLine("Total spent: $" + spent + " out of $" + budget);

