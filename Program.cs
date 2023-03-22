using System;

Console.Write("Type 1st number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Type 2nd number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n{numberOne} + {numberTwo} = {numberOne + numberTwo}");
Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
Console.WriteLine($"{numberOne} : {numberTwo} = {numberOne / numberTwo} residual({numberOne % numberTwo})");
Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}\n");

// logical operator
string massage = 
    numberOne >= 0 && numberTwo >= 0
    ? "Numbers are positive"
    : "Numbers are negative";
Console.WriteLine(massage);

// if else, ternary operator
if(numberOne == numberTwo){
    Console.WriteLine("Numbers are equal");
} else {
    Console.WriteLine(numberOne > numberTwo ? "1st number is large" : "2nd number is large");
}

Console.WriteLine("\nYou'll be healthy...");