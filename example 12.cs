HashSet<int> uniqueNumbers = new HashSet<int>();

int[] values = { -5, 10, -15, 20, -5, 10, 25 };

foreach (int num in values)
{
    uniqueNumbers.Add(Math.Abs(num));
}

Console.WriteLine("Unique absolute values count: " + uniqueNumbers.Count);
