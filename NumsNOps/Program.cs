// Collect the bill amount and tip percentage
 Console.WriteLine("Enter your bill details:\n");
 Console.Write("Bill amount:    ");
 decimal billAmount = Convert.ToDecimal(Console.ReadLine());
 Console.Write("Tip percentage: ");
 decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());

 // Display the entered values
 Console.WriteLine("\nBill details:");
 Console.WriteLine($"  Bill amount:    {billAmount:C}");
 Console.WriteLine($"  Tip percentage: {tipPercentage}%");

 // Calculate the tip and total
 decimal tipAmount = Math.Round(billAmount * (tipPercentage / 100), 2);
 decimal totalAmount = Math.Round(billAmount + tipAmount, 2);

 // Display the results
 Console.WriteLine($"\nTip amount:   ${tipAmount}");
 Console.WriteLine($"Total amount: ${totalAmount}");
