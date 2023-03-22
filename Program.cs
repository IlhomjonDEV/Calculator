using System;

Console.Write("Enter first number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n{numberOne} + {numberTwo} = {numberOne+numberTwo}");
Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne-numberTwo}");
Console.WriteLine($"{numberOne} : {numberTwo} = {numberOne/numberTwo} residual({numberOne%numberTwo})");
Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne*numberTwo}");

Console.WriteLine("\nYou'll be healthy...");