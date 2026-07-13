// Console.WriteLine(":::::::::::::::::: Basic Usage :::::::::::::::::::::::::");

// for (int row = 1; row <= 3; row++)
// {
//     for (int col = 1; col <= 3; col++)
//     {
//         Console.Write("(" + row + "," + col + ")");
//     }

//     Console.WriteLine();
// }

Console.WriteLine(":::::::::::::::::: Clinic Weekly Slot Generator :::::::::::::::::::::::::");

Console.WriteLine("Open: 09:00 to 17:00 | Slot Duration: 30 mins");

for (int day = 1; day <= 7; day++)
{
    Console.WriteLine("Day #" + day + " →");

    for (int hour = 9; hour <= 16; hour++)
    {
        Console.WriteLine(hour + ":00-" + hour + ":30");
        Console.WriteLine(hour + ":30-" + (hour + 1) + ":00");
    }
}