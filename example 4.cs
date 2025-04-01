Random dice = new Random();
int roll1 = dice.Next(1, 50);
int roll2 = dice.Next(1, 101);
int roll3 = dice.Next(20, 80);
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
