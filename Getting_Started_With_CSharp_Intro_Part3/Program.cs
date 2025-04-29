// Compares two string literals. Both are "a", so this returns true.
Console.WriteLine("a" == "a");  // Output: True

// Compares two string literals: "a" and "A". Since C# string comparison is case-sensitive by default, this returns false.
Console.WriteLine("a" == "A");  // Output: False

// Compares two integers: 1 and 2. They are not equal, so this returns false.
Console.WriteLine(1 == 2);  // Output: False

// Compares a string variable with the string literal "a". Since myValue is "a", the result is true.
string myValue = "a";
Console.WriteLine(myValue == "a");  // Output: True

// Compares two strings after trimming whitespace (if any) and converting to lowercase.
// This ensures case-insensitive and whitespace-insensitive comparison.
string value1 = "a";
string value2 = "A";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());  // Output: True

// Checks if the word "fox" exists in the sentence. Since it does, this returns true.
string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine(pangram.Contains("fox"));  // Output: True

// Checks if the word "cat" exists in the sentence. It doesn't, so this returns false.
Console.WriteLine(pangram.Contains("cat"));  // Output: False

// Checks if the result of Contains("fox") is false. Since it is true, the comparison returns false.
Console.WriteLine(pangram.Contains("fox") == false);  // Output: False

// The same as the line above but using the NOT operator (!) instead of equality comparison.
// Since pangram.Contains("fox") is true, !true = false.
Console.WriteLine(!pangram.Contains("fox"));  // Output: False


/* Exercise: Implement conditional operator
Suppose you need to quickly determine whether a customer's purchase is eligible for a promotional discount. The details for the promotion indicate that when a purchase value is greater than 1000 euros, the purchase is eligible for a 100 euro discount. If the purchase amount is 1000 euros or less, the purchase is eligible for a 50 euro discount.
*/

int saleAmount = 1003;
//int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)} euros");  // Output: Discount: 100 euros


/* Exercise - Complete a challenge activity using conditional operators
In this challenge, you'll implement a conditional operator to simulate a "coin flip". The resulting decision logic will display either heads or tails.

*/

Random coin = new Random(); // Create a new instance of the Random class to generate random numbers.
int flip = coin.Next(0, 2);// Generate a random number between 0 and 1 (inclusive of 0, exclusive of 2).
Console.WriteLine((flip == 0) ? "heads" : "tails");// Output "heads" if flip is 0, otherwise output "tails".

//Console.WriteLine((coin.Next(0,2)==0)?"heads":"tails"));

/*Exercise - Complete a challenge activity using Boolean expressions
In this challenge, you'll implement decision logic based on a series of business rules. The business rules specify the access that will be granted to users based on their role-based permissions and their career level. Code branches will display a different message to the user depending on their permissions and level.
*/
string permission = "Admin|Manager";
int level = 54;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome,Siper Admin!");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("contact an admin for access.");
    }
    else
    {
        Console.WriteLine("you donot have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("you donot have sufficient privileges.");
}

