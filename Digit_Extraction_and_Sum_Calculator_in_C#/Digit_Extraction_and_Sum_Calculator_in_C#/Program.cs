Console.WriteLine("--------------------------------------");
Console.WriteLine("     THREE/DIGIT NUMBER ANALYZER     ");
Console.WriteLine("--------------------------------------");
Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine());

// Extract digits
int ones = number % 10;
int tens = (number % 100) / 10;
int hundreds = number / 100;

Console.WriteLine("DIGIT BREAKDOWN");
Console.WriteLine($"Ones Digit     : {ones}");
Console.WriteLine($"Tens Digit     : {tens}");
Console.WriteLine($"Hundreds Digit : {hundreds}");

int sum = ones + tens + hundreds;

Console.WriteLine("RESULT");
Console.WriteLine($"Sum of Digits  : {sum}");
Console.WriteLine("--------------------------------------");
Console.WriteLine("Calculation Completed!");
Console.WriteLine("--------------------------------------");


