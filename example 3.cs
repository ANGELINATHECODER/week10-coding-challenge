int fahrenheit = 104;
decimal temperature = ((fahrenheit - 32) * 5m / 9);
Console.WriteLine("The temperature is " + temperature + " degrees Celsius");

int newFahrenheit = 86;
decimal newTemperature = ((newFahrenheit - 32m) * 5m / 9m);
Console.WriteLine("The temperature is " + Math.Round(newTemperature) + " degrees Celsius");
