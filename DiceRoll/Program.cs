Console.WriteLine("\n\nHello there ...\nDo you want to play a dice roll game with me?!!!");
Console.Write("Enter 1 for yes or 0 for no: ");
bool wantToPlay = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

if (wantToPlay)
{
	Console.WriteLine("\n\nCool! You can choose how many rounds you want to play.");
	Console.Write("\nEnter a number greater than 2: ");
	int rounds = Convert.ToInt32(Console.ReadLine());
	int[] rolls = new int[rounds];
	int[] thresholds = new int[3];
	thresholds[0] = 5*rounds + 1;
	thresholds[1] = 5*rounds - 5;
	thresholds[2] = 5*rounds - 8;
	Random dice = new Random();
	int total = 0;
	
	for (int i = 0; i< rounds; i++)
	{
		rolls[i] = dice.Next(1, 7);
		total += rolls[i];
	}
	
	Console.WriteLine($"\n\nYour total before bonus is: {total}");

	var counts = new Dictionary<int, int>();

	foreach (int roll in rolls)
	{
		if (counts.ContainsKey(roll))
		{
			counts[roll]++;
		}
		else
		{
			counts[roll] = 1;
		}
	}

	foreach (var entry in counts)
	{
		if (entry.Value > 1)
		{
			Console.WriteLine($"You have {entry.Value} times {entry.Key}!");
			total += 2*(entry.Value - 1) + (entry.Value - 1)^2;
		}
	}

	Console.WriteLine($"\n\nYour total after bonus is: {total}");	
	
	// Display the final result
	if (total >= thresholds[0])
	{
		Console.WriteLine("You win a new car!");
	}
	else if (total >= thresholds[1])
	{
		Console.WriteLine("You win a new laptop!");
	}
	else if (total >= thresholds[2])
	{
		Console.WriteLine("You win a trip for two!");
	}
	else
	{
		Console.WriteLine("You win a kitten!");
	}		
} 
else
{
	Console.WriteLine("\n\nNo problem! Hope you can make it next time, cheers!!");
}
