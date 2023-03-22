﻿using System;

Console.Write("Type 1st number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Type 2nd number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nAddition, subtraction, division and multiplication: ");
Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
Console.WriteLine($"{numberOne} : {numberTwo} = {numberOne / numberTwo} residual({numberOne%numberTwo})");
Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");

Console.WriteLine("\nComparison numbers: ");
Console.WriteLine($"1st number is greater than 2nd : {numberOne > numberTwo}");
Console.WriteLine($"1st number is greater than or equal to 2nd : {numberOne >= numberTwo}");
Console.WriteLine($"1st number is smaller than 2nd : {numberOne < numberTwo}");
Console.WriteLine($"1st number is less than or equal to 2nd : {numberOne <= numberTwo}");
Console.WriteLine($"Numbers is equal : {numberOne == numberTwo}");
Console.WriteLine($"Numbers is not equal : {numberOne != numberTwo}");

Console.WriteLine("\nConditional check of numbers: ");
if(numberOne == numberTwo){
    Console.WriteLine("Numbers are equal");
} else if(numberOne < numberTwo){
    Console.WriteLine("2nd number is large");
} else {
    Console.WriteLine("1st number is large");
}

Console.WriteLine("\nYou'll be healthy...");