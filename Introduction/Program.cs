
Console.WriteLine("Hello, World!");

// This is a simple C# console application that prints "Hello, World!" to the console.
// It serves as a basic introduction to C# programming and the .NET environment.
// It compiles your code into an executable format that a computer can understand.
// It runs your compiled application and, when written correctly, will output "Hello World!"
// To run this code, you can use the .NET CLI or an IDE like Visual Studio.

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("Your wrote your first line of C# code.");

// Difference between Console.Write and Console.WriteLine:
// Console.Write does not add a new line after the output, while Console.WriteLine does.
// Console.WriteLine automatically appends a new line after the output, moving the cursor to the next line.

/*
What is a literal value?
A literal value is a constant value that never changes. Previously, you displayed a literal string to the output console. In other words, you literally wanted that string of alphanumeric characters H, e, l, l, o, and so on, displayed in the output console.


*/

// Use character literals: If you only wanted a single alphanumeric character printed to screen, you could create a char literal by surrounding one alphanumeric character in single quotes. The term char is short for character. In C#, this data type is officially named "char", but frequently referred to as a "character".
Console.WriteLine('b');

//Use integer literals: If you want to display a numeric whole number (no fractions) value in the output console, you can use an int literal. The term int is short for integer, which you may recognize from studying math. In C#, this data type is officially named "int", but frequently referred to as "integer". An int literal requires no other operators like the string or char.
Console.WriteLine(123);

/*
Use floating-point literals

A floating-point number is a number that contains a decimal, for example 3.14159. C# supports three data types to represent decimal numbers: float, double, and decimal. Each type supports varying degrees of precision.
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
*/

//To create a float literal, append the letter F after the number. In this context, the F is called a literal suffix. The literal suffix tells the compiler you wish to work with a value of float type. You can use either a lower-case f or upper-case F as the literal suffix for a float.
Console.WriteLine(0.32F);
//To create a double literal, just enter a decimal number. The compiler defaults to a double literal when a decimal number is entered without a literal suffix.
Console.WriteLine(2.43);
//To create a decimal literal, append the letter m after the number. In this context, the m is called a literal suffix. The literal suffix tells the compiler you wish to work with a value of decimal type. You can use either a lower-case m or upper-case M as the literal suffix for a decimal.
Console.WriteLine(12.3963m);
//Use Boolean literals: If you wanted to print a value representing either true or false, you could use a bool literal.The term bool is short for Boolean. In C#, they're officially referred to as "bool", but often developers use the term "Boolean".
Console.WriteLine(true);
Console.WriteLine(false);

/*
Why emphasize data types?

-> Data types play a central role in C#. In fact, the emphasis on data types is one of the key distinguishing features of C# compared to other languages like JavaScript. 
*/


/*
Declare Variables: A literal is literally a hard-coded value. Hard-coded values are values that are constant and unchanged throughout the execution of the program. However, most applications will require you to work with values that you don't know much about ahead of time.

What is a variable?
-> A variable is a container for storing a type of value. Variables are important because their values can change, or vary, throughout the execution of a program. Variables can be assigned, read, and changed. You use variables to store values that you intend to use in your code.
A variable name is a human-friendly label that the compiler assigns to a memory address. When you want to store or change a value in that memory address, or whenever you want to retrieve the stored value, you just use the variable name you created.

- Variables are temporary values you store in the computer's memory.
- Before you can use a variable, you have to declare it.
- To declare a variable, you first select a data type for the kind of data you want to store, and then give the variable a name that follows the rules.

*/

string firstName; // // The variable firstName is declared, but not initialized. It has no value assigned to it yet.
firstName = "John";// The variable firstName is declared and initialized with the value "John". It now holds a string value that can be used later in the program.
Console.WriteLine(firstName);// The value of the variable firstName is printed to the console, which will output "John".
firstName = "Jane";// The value of the variable firstName is changed to "Jane". Variables can be reassigned to new values at any time.
Console.WriteLine(firstName);// The updated value of the variable firstName is printed to the console, which will now output "Jane".    

int gameScore;
bool isGameOver;
char firstLetterOfFirstName;


/* Declare implicitly typed local variables:
What are implicitly typed local variables?
-> An implicitly typed local variable is created by using the var keyword followed by a variable initialization. 
For example: var firstName = "John";
// The compiler infers the type of the variable based on the value assigned to it. In this case, firstName is inferred to be of type string because it is initialized with a string value.
var firstName = "John"; // The compiler infers the type of firstName to be string based on the assigned value.
*/

var message = "Hello world!";

// Exercise: Use Console.Write to print a message to the console that includes a name, number of messages, and temperature.
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;
Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");



/*
character escape sequences:
- Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
- Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
- Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
- Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
- Unicode characters may not print correctly depending on the application.

*/
Console.WriteLine("Hello, \nworld!"); // This will print "Hello," on one line and "world!" on the next line.
Console.WriteLine("Hello, \tworld!"); // This will print "Hello," followed by a tab space and then "world!" on the same line.

//Console.WriteLine("Hello "World"!"); // This will cause a compilation error because the double quotes around "World" are not escaped. Correct way to include double quotes in a string is Console.WriteLine("Hello \"World\"!")
Console.WriteLine("Hello \"World\"!"); // This will print Hello "World"!

Console.WriteLine("c:\\source\\project"); // This will print c:\source\project


// Exercies: create the mockup of the command line tool
Console.WriteLine("Generating invoices for customer \"Customer A\"...");
Console.WriteLine("Invoice 1: $100.00 \t completed!");
Console.WriteLine("Invoice 2: $200.00 \t completed!");
Console.WriteLine("\n All invoices for customer \"Customer A\" have been generated successfully!");

//Verbatim string literal - A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. To create a verbatim string, use the @ directive before the literal string.
Console.WriteLine(@"Generating invoices for customer ""Customer A""...");// This will print Generating invoices for customer "Customer A"...
Console.Write(@"c:\invoices");

// String Concatenation
string firstName = "Bob"; // This declares a variable firstName and initializes it with the value "Bob".
string message = "Hello " + firstName; // This will concatenate the string "Hello " with the value of firstName, resulting in "Hello Bob".
Console.WriteLine(message); // This will print "Hello Bob" to the console.

// String Interpolation - String interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions. An interpolation expression is indicated by an opening and closing curly brace symbol { }.

string message = $" Hello , {firstName}!"; //// This will create a string that includes the value of firstName, resulting in "Hello, Bob!".
Console.WriteLine(message); // This will print "Hello, Bob!" to the console.

// String Interpolation with multiple variables
string lastName = "smith";
string fullName = $"{firstName} {lastName}"; // This will create a string that includes the values of firstName and lastName, resulting in "Bob Smith".
Console.WriteLine(fullName);// This will print "Bob Smith" to the console.

// Combine verbatim literals and string interpolation
string projectName = "My Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");


//Perform basic operations on numbers in C# 
//Exercise - Perform addition with implicit data conversion

int firstNumber = 12; // This declares a variable firstNumber and initializes it with the value 12.
// Implicit data conversion allows you to combine different numeric types in an expression without needing to explicitly convert them.
int secondNumber = 3; // This declares a variable secondNumber and initializes it with the value 3.
Console.WriteLine(firstNumber + secondNumber); // This will print the result of adding firstNumber and secondNumber, which is 15.

string firstName = "Bob";
int widgetsSold = 17;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // This will print "Bob sold 177 widgets." because the integer 7 is implicitly converted to a string and concatenated with the other strings.

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // This will print "Bob sold 14 widgets." because the parentheses ensure that the addition is performed before the concatenation, resulting in the correct total of widgets sold.

//Exercise - Perform math operations

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum); //    This will print "Sum: 12"
Console.WriteLine("Difference: " + difference); // This will print "Difference: 2"
Console.WriteLine("Product: " + product); // This will print "Product: 35"
Console.WriteLine("Quotient: " + quotient);     // This will print "Quotient: 1" because integer division truncates the decimal part.

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}"); // This will print "Decimal quotient: 1.4" because the decimal type allows for fractional values.

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient); // This will print "1.4" because both first and second are explicitly cast to decimal before the division, allowing for a precise decimal result.

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); // This will print "0" because 200 divided by 5 leaves no remainder.
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}"); // This will print "2" because 7 divided by 5 leaves a remainder of 2.

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1); // This will print "23" because multiplication is performed before addition, so 4*5 is calculated first, resulting in 20, and then 3 is added to it.
Console.WriteLine(value2); // This will print "23" and "35" respectively, demonstrating the order of operations where multiplication is performed before addition unless parentheses are used to change the order.

//Exercise - Increment and decrement values
int value = 0;   // This declares a variable value and initializes it with the value 0.
value = value + 5; // This adds 5 to the current value of value, resulting in value being 5.
value += 5; // This is a shorthand way to add 5 to value, resulting in value being 10.


int value = 1;
value = value + 1;
Console.WriteLine("first increment : " + value);
value += 1;
Console.WriteLine("second increment : " + value);
value++;
Console.WriteLine("third increment: " + value);
value = value - 1;
Console.WriteLine("first decrement: " + value);
value -= 1;
Console.WriteLine("second decrement : " + value);
value--;
Console.WriteLine("third decrement: " + value);

int value = 1; // This declares a variable value and initializes it with the value 1.
value++; // This increments the value by 1, so value becomes 2.
Console.WriteLine("first: " + value); //    This will print "first: 2"
Console.WriteLine($"Second: {value++}"); // This will print "Second: 2" and then increment value to 3.
Console.WriteLine("second: " + value); // This will print "second: 3"
value += 1; // This is another way to increment value by 1, so value becomes 4.
Console.WriteLine("third: " + value);   // This will print "third: 4"
value = 3; // This declares a variable value and initializes it with the value 3.
Console.WriteLine("fourth: " + (++value));  // This will print "fourth: 4" because the increment operator is used before the variable, so value is incremented to 4 before being printed.


//  Calculate Celsius given the current temperature in Fahrenheit
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius."); //    This will print "The temperature is 34.4444444444444 Celsius." because the formula for converting Fahrenheit to Celsius is applied correctly.


