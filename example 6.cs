Random random = new Random();
int daysUntilExpiration = random.Next(1, 15);
int discountPercentage = 0;

if (daysUntilExpiration == 1)
{
    discountPercentage = 25;
}
if (daysUntilExpiration <= 5)
{
    discountPercentage = 15;
}
if (daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired!");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save " + discountPercentage + "%!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine("Your subscription expires in: " + daysUntilExpiration + " days.");
    Console.WriteLine("Renew now and save " + discountPercentage + "%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription expires in: " + daysUntilExpiration + " days.");
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
