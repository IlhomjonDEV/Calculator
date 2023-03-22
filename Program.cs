using System;

Console.Write("Type 1st number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter operation(+,-,/,*,%) ");
string operation = Console.ReadLine();
Console.Write("Type 2nd number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

// switch 
switch (operation){
    case "+":
        Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
        break;
    case "-":
        Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
        break;
    case "/":
        Console.WriteLine($"{numberOne} : {numberTwo} = {(float)numberOne / numberTwo}");
        break;
    case "*":
        Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}\n");
        break;
    case "%":
        Console.WriteLine($"{numberOne} % {numberTwo} = {numberOne % numberTwo}");
        break;
    default :
        Console.WriteLine("Operation Not Found!");
        break;
}

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