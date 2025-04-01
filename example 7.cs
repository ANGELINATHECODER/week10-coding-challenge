string[] orderIds = { "D123", "E234", "B345", "A15", "C177", "F3003", "B235", "A179" };

foreach (string item in orderIds)
{
    if (item.StartsWith("A"))
    {
        Console.WriteLine(item);
    }
}
