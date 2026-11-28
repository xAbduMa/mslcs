for (int i = 1; i <= 100; i++)
{
	int[] mods ={i%3, i%5};
	 
	if (mods.All(x => x == 0))
	{
		Console.WriteLine($"{i}\t- FizzBuzz");
	}
	else if (mods[0] == 0)
	{
		Console.WriteLine($"{i}\t- Fizz");
	}
	else if (mods[1] == 0)
	{
		Console.WriteLine($"{i}\t- Buzz");
	}
	else
	{
		Console.WriteLine($"{i}");
	}
}
