// See https://aka.ms/new-console-template for more information
// Sample Input

using ServingDrinksProject;

Func<int, double> calculatePrice = new BlueOcean().CalculatePrice;

var amount = new PrepareBill().CalculateDrinkPrice(calculatePrice, 10);
Console.WriteLine($"Amount for BlueOcean: {amount}");

calculatePrice = new Mojito().CalculatePrice;
amount = new PrepareBill().CalculateDrinkPrice(calculatePrice, 5);
Console.WriteLine($"Amount for Mojito: {amount}");
