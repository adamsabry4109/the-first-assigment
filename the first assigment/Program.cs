using System;

Console.WriteLine("Welcome to Islam's carpet cleaning service");
Console.WriteLine("We have a 30-day offer. Hurry up!");
Console.WriteLine("The offer is : 25.0$ per small carpet\n35.0$ per large carpet\nNote that there is a 6% tax on the total.");
Console.WriteLine("Please enter the number of small carpets ??");
int smallCarpet = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number of large carpets ??");
int largeCarpet = Convert.ToInt32(Console.ReadLine());
int value = smallCarpet * 25 + largeCarpet * 35;
Console.WriteLine($"cost : {value}");
double tax = value * 6.0 / 100;
Console.WriteLine($"Tax : {tax}");
Console.WriteLine("-----------------------------------");
double total = tax + value;
Console.WriteLine($"Total estimate : {total}$");
Console.WriteLine("this estimate is valid for 30 days");