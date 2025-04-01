Random randomID = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = randomID.Next(70, 75);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = randomID.Next(10, 500).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
