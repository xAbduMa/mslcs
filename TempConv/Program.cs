// Temperature Converter: Two-way Fahrenheit to Celsius
Console.WriteLine("\n=== Temperature Converter ===");
Console.Write("\nChoose Original Units [1: Fahrenheit 2: Celsius]: ");
int originalUnits = Convert.ToInt32(Console.ReadLine());
decimal originalTemp = 0;

switch (originalUnits)
{
    case 1:
        // Convert from Fahrenheit to Celsius
		Console.Write("\n\tEnter Original Temperature in Fahrenheit: ");
		originalTemp = Convert.ToDecimal(Console.ReadLine());
		Console.Write($"\tTemperature in Celsius: {(originalTemp-32)*5/9:F1}\n");
        break;

    case 2:
		Console.Write("\n\tEnter Original Temperature in Celsius: ");
		originalTemp = Convert.ToDecimal(Console.ReadLine());
		Console.Write($"\tTemperature in Fahrenheit: {(originalTemp*9/5)+32:F1}\n");	
        break;

    default:
        // Optional: executes if no other case matches
		Console.Write("You did not enter a valid choice.");
        break;
}


