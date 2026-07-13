Console.WriteLine("\n\n:::::::::::::::: Looping Through Arrays ::::::::::::::::");


int[] numbers = { 10, 20, 30, 40, 50, 7123 };
{

	Console.WriteLine("\n\nfor => ");
	//for (int index = 0; index < numbers.Length; index++)
	for (var index = 0; index < numbers.Length; index++)
	{
		if (index == 0) //! First Element
		{
			Console.Write($"[ {numbers[index]}");
		}
		else if (index == numbers.Length - 1) //! Last Element
		{
			Console.Write($", {numbers[index]} ]");
		}
		else //! Middle Elements
		{
			Console.Write($" ,{numbers[index]}");
		}
	}

}



{
	//! 2. while loop (manual index control)
	Console.WriteLine("\n\nwhile => ");

	int index = 0;

	while (index < numbers.Length)
	{
		if (index == 0) //! First Element
		{
			Console.Write($"[ {numbers[index]}");
		}
		else if (index == numbers.Length - 1) //! Last Element
		{
			Console.Write($", {numbers[index]} ]");
		}
		else //! Middle Elements
		{
			Console.Write($" ,{numbers[index]}");
		}

		++index;
	}
}


{
	//! 3. do-while loop (executes at least once)

	Console.WriteLine("\n\ndo-while => ");

	int index = 0;

	do
	{
		if (index == 0) //! First Element
		{
			Console.Write($"[ {numbers[index]}");
		}
		else if (index == numbers.Length - 1) //! Last Element
		{
			Console.Write($", {numbers[index]} ]");
		}
		else //! Middle Elements
		{
			Console.Write($" ,{numbers[index]}");
		}
		++index;
	}
	while (index < numbers.Length);

}

{
	//! 4. foreach loop (value-based — no index)

	Console.WriteLine("\n\nforeach => ");

	bool isFirst = true;


	foreach (var number in numbers)
	{
		if (isFirst == true)
		{
			Console.Write($"[ {number}");
			isFirst = false;
		}
		else
		{
			Console.Write($", {number}");
		}
	}
	Console.Write($"]");
	Console.WriteLine("\n\n");

}