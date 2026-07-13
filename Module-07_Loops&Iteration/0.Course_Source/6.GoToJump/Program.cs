Console.WriteLine(":::::::::::::::::: Basic Usage :::::::::::::::::::::::::");

int counter = 0;

Start:

counter++;

if (counter <= 10)
{
    Console.WriteLine(counter);
    goto Start;
}