string[] pallets = { "D20", "C15", "E25", "B10" };

Console.WriteLine("Sorted ....");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Reverse ....");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}
