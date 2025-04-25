// Exercise - Call the methods of a .Net class
// This program demonstrates how to call methods from a .NET class.
Console.WriteLine("Hello, World!");
//code sample that implements methods of the System.Random and System.Console classes.This code simulates a dice roll using the Random.Next() method to generate a number, and the Console.WriteLine() method to display the value.
Random dice = new Random(); // creates a new instance of the Random class to create a new object called dice
int roll = dice.Next(1, 8); // Generates a random number between 1 and 7 (inclusive of 1, exclusive of 8)
Console.WriteLine($"You rolled a {roll} on the dice!");// Outputs the result of the dice roll

/* Overloaded methods : An overloaded method is defined with multiple method signatures. Overloaded methods provide different ways to call the method or provide different types of data.
In this example, we are invoking three separate overloaded versions of the WriteLine() method.
The first WriteLine() method uses a method signature that defines an int parameter.
The second WriteLine() method uses a method signature that defines zero parameters.
The third WriteLine() method uses a method signature that defines a string parameter.
*/
int number = 7;
string text = "Hey!";
Console.WriteLine($"The number is {number}");
Console.WriteLine();
Console.WriteLine($"The text is {text}");


// For instance Random.Next() method has overloaded versions that enable us to set various level of constrain on the randomly generated numbers. Generates random integer values with different levels of constraint
int roll1 = dice.Next();
int roll2 = dice.Next(100);
int roll3 = dice.Next(20, 105);
Console.WriteLine($"You rolled a {roll1} on the dice!");
Console.WriteLine($"You rolled a {roll2} on the dice!");
Console.WriteLine($"You rolled a {roll3} on the dice!");

// code challenge : implement a method of a math class that returns the larger of two numbers
int firstValue = 10;
int secondValue = 20;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine($"The larger value between {firstValue} and {secondValue} is {largerValue}.");
