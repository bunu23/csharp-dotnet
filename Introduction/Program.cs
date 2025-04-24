
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