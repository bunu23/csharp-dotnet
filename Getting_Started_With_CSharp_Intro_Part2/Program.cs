﻿// Exercise - Call the methods of a .Net class
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


// CREATE A DECISION LOGIC WITH if-else STATEMENT
if (largerValue > 15)
{
    Console.WriteLine("The larger value is greater than 15.");
}
else
{
    Console.WriteLine("The larger value is less than or equal to 15.");
}

// BOOLEAN EXPRESSION
string message = "The quick brown fox jumps over the lazy dog.";
bool containsFox = message.Contains("fox");
Console.WriteLine($"Does the message contain 'fox'? {containsFox}");

bool result = message.Contains("dog");
Console.WriteLine(result);
if (message.Contains("fox"))
{
    Console.WriteLine("What a clever fox!");
}


// continue the dice example by adding nested decisiion logic with if , else if, and else statements

int roll4 = dice.Next(1, 7);
int roll5 = dice.Next(1, 7);
int roll6 = dice.Next(1, 7);
int total = roll4 + roll5 + roll6;
Console.WriteLine($" You rolled a {roll4}, {roll5}, and {roll6} on the dice! Total: {total}");

if ((roll4 == roll5) || (roll5 == roll6) || (roll4 == roll6))
{
    if ((roll4 == roll5) && (roll5 == roll6))
    {
        Console.WriteLine("You rolled triples! +5 bonus to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to toal");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("you win a package of chips!");
}
else if (total == 30)
{
    Console.WriteLine("You win a trip for two to Hawaii!");
}
else
{
    Console.WriteLine("yo win a  prize of a candy bar!");
}


/*
CHALLENGE: Improve renewal rate of subscriptions
You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(6);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

// Getting  Started with Array
//Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#

string[] fradulentOrderIDs = new string[3]; // Declare an array of strings with a size of 3
fradulentOrderIDs[0] = "12345";// Assign a value to the first element of the array
fradulentOrderIDs[1] = "67890";// Assign a value to the second element of the array
fradulentOrderIDs[2] = "54321";// Assign a value to the third element of the array
Console.WriteLine($"first:{fradulentOrderIDs[0]}");// Access and print the first element of the array
Console.WriteLine($"second:{fradulentOrderIDs[1]}");// Access and print the second element of the array
Console.WriteLine($"third:{fradulentOrderIDs[2]}");// Access and print the third element of the array
fradulentOrderIDs[1] = "11111"; // Update the second element of the array
Console.WriteLine($"Updated second:{fradulentOrderIDs[1]}");// Access and print the updated second element of the array

//You can initialize an array during declaration just like you would a regular variable.
string[] orderIDs = ["12345", "67890", "54321"]; // Declare and initialize an array of strings with three elements
Console.WriteLine($"first:{orderIDs[0]}");// Access and print the first element of the array
Console.WriteLine($"second:{orderIDs[1]}");// Access and print the second element of the array
Console.WriteLine($"third:{orderIDs[2]}");// Access and print the third element of the array

Console.WriteLine($"The length of the array is{orderIDs.Length}");// Print the length of the array


/*
Exercise - Implement the foreach statement
Suppose you work for a manufacturing company. The company needs you to complete an inventory of your warehouse to determine the number of products that are ready to ship. In addition to the total number of finished products, you need to report the number of finished products stored in each individual bin in your warehouse, along with a running total. This running total will be used to create an audit trail so you can double-check your work and identify "shrinkage".
*/

int[] inventory = { 200, 100, 150, 75, 50, 25, 10, 5, 1 }; // create an array of type int to store the number of finished products in each bin
int sum = 0;
int bin = 0;
//iterate throught the array
foreach (int items in inventory)
{
    sum += items; // add the current value stored in the items to the sum variable
    bin++;
    Console.WriteLine($"Bin {bin} ={items}(Running total:{sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");


/*
Exercise - Complete a challenge activity for nested iteration and selection statements
Code challenge - Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.
*/

string[] orderId = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string order_ID in orderId)
{
    if (order_ID.StartsWith("B"))
    {
        Console.WriteLine(order_ID);
    }
}