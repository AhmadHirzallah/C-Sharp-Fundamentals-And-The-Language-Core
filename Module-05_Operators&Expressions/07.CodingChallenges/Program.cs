Console.WriteLine("Module 05 | Operators & Expressions\n\n\n\n");



#region Exercise 1

{
	Console.WriteLine("================================ Exercise 1 — Easy ================================\n\n" +
		"Problem:\nDeclare two integer variables a = 10 and b = 4 . Print the result of adding, subtracting, multiplying,\nand dividing them (one result per line).\n\nExpected Input:\nNone\n\nExpected Output:\n14\n6\n40\n2");

	Console.WriteLine("\n\n-------------\n" +
		"SOLUTION:\n");

	int a = 10;
	int b = 4;

	Console.WriteLine($"{nameof(a)} Variable = {a}\n" +
		$"{nameof(b)} Variable = {b}\n" +
		$"Adding Result = {a + b}" +
		$"\nSubtracting Result = {a - b}\n" +
		$"Multiplying Result = {a * b}\n" +
		$"Dividing Result = {a / b}\n\n\n");

}

#endregion


#region Exercise 2 — Easy

{
	Console.WriteLine("\n\n================================ Exercise 2 — Easy ================================ \r\n\nProblem:\r\nDeclare an integer x = 17 . Print the remainder when x is divided by 5 .\r\n\nExpected Input:\r\n\nNone\r\n\nExpected Output:\r\n2");

	int x = 17;

	//x %= 5;
	Console.WriteLine($"\n\n" +
		$"------------------\n" +
		$"Final Result => \n\tremainder: " +
		$"x %= 5 => x = 17 % 5 = {x %= 5}");
}


#endregion


#region Exercise 3 — Medium

{
	Console.WriteLine("\n\n\n\n================================ Exercise 3 — Medium ================================\n\n" +
		"\nProblem:\r\nStart with a variable score = 10 . Use compound assignment operators to:\r\n1. Add 5 to it\r\n2. Multiply it by 2\r\n3. Subtract 3 from it\r\n\nPrint the final value.\r\n\nExpected Input:\r\nNone\r\n\nExpected Output:\r\n27");


	float score = 10.0f;

	Console.WriteLine($"\n\n" +
				$"------------------\n" +
				$"Final Result => \n\t");

	score += 5;
	Console.WriteLine($"score += 5; ===>> {score}");

	score *= 2;
	Console.WriteLine($"score *= 2; ===>> {score}");

	score -= 3;
	Console.WriteLine($"score -= 3; ===>> {score}");

}

#endregion


#region Exercise 4 — Medium

{
	Console.WriteLine("\n\n\n\n================================ Exercise 4 — Medium ================================\n\n" +
	"Problem:\r\nDeclare int a = 5 and int b = 10 . Using comparison operators, print whether a is less than b ,\r\nwhether they are equal, and whether a is greater than or equal to b .\r\n\n" +
	"Expected Input:\r\nNone\r\n\nExpected Output:\r\nTrue\r\nFalse\r\nFalse");

	Console.WriteLine($"\n\n" +
				$"------------------\n" +
				$"Final Result => \n\t");

	int a = 5;
	int b = 10;

	Console.WriteLine($"[{nameof(a)}] = {a}    &&&&&    [{nameof(b)}] = {b}\n");
	Console.WriteLine($"Is: '[a] is less than [b]' => {a < b}");
	Console.WriteLine($"Is: '[a] equal [b]' => {a == b}");
	Console.WriteLine($"Is: '[a] is greater than or equal [b]' => {a >= b}");

}

#endregion


#region Exercise 5 — Medium

{
	Console.WriteLine($"\n\n\n\n================================ Exercise 5 — Medium ================================\r\n\n" +
		$"Problem:\r\nDeclare bool isRaining = true and bool hasUmbrella = false . Use logical operators to print:\r\n1. Whether it is raining AND they have an umbrella\r\n2. Whether it is raining OR they have an umbrella\r\n3. Whether it is NOT raining\r\n\n" +
		$"Expected Input:\r\nNone" +
		$"\r\n\nExpected Output:\r\nFalse\r\nTrue\r\nFalse");

	Console.WriteLine($"\n\n" +
				$"------------------\n" +
				$"Final Result => \n\t");

	bool isRaining = true;
	bool hasUmbrella = false;

	Console.WriteLine($"{nameof(isRaining)} = {isRaining}\n" +
		$"{nameof(hasUmbrella)} = {hasUmbrella}\n\n");

	Console.WriteLine($"[Is it raining AND they have an umbrella] => [isRaining && hasUmbrella]:\n{isRaining && hasUmbrella}\n\n");
	Console.WriteLine($"[Is it raining OR they have an umbrella] => [isRaining || hasUmbrella]:\n{isRaining || hasUmbrella}\n\n");
	Console.WriteLine($"[Whether it is NOT raining] => [!isRaining]:\n{!isRaining}\n\n");
}

#endregion


#region MyRegion

{
	Console.WriteLine($"\n\n\n\n================================ Exercise 6 — Hard ================================\r\n" +
		$"\nProblem:\r\nYou have a variable counter = 1 . Use increment and decrement operators and consider operator\r\nprecedence carefully. Print counter after a pre-increment, then print the result of using counter in the\r\nexpression counter++ + 5 (think: does counter increment before or after the expression is\r\nevaluated?). Finally print counter again to see its new state." +
		$"\r\n\nExpected Input:\r\nNone\r\n\nExpected Output:\r\n2\r\n7\r\n3\r\n");

	Console.WriteLine($"\n\n" +
			$"------------------\n" +
			$"Final Result => \n\t");

	short counter = 1;
	Console.WriteLine($"Initial counter value: {counter}\n\n" +
		$"Printing counter after a pre-increment:\n" +
		$"[++{counter}] = {++counter}\n\n" +
		$"print the result of using counter in the expression [counter++ + 5]:\n" +
		$"[{counter}++ + 5] = {counter++ + 5}\n\n" +
		$"[counter] increment [[before]] the expression is evaluated." +
		$"\n\n[{nameof(counter)}] final result: {counter}");
}

#endregion