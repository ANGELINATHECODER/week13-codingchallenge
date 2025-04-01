# week13-codingchallenge
Code challenge - Report the Order IDs that need further investigation

Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You'll write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.

Declare an array and initialize it to contain the following elements:
B123
C234
A345
C15
B177
G3003
C235
B179

These values represent the fraudulent Order ID data that your application will use.

Create a foreach /for loop statement to iterate through each element of your array.

Report the Order IDs that start with the letter "B".

You will need to evaluate each element of the array. Report the potentially fraudulent Order IDs by detecting the orders that start with the letter "B". To determine whether or not an element starts with the letter "B", use the String.StartsWith() method. Here's a simple example of how to use the String.StartsWith() method that you can adapt for your code:

string name = "Bob";
if (name.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B'!");
}

Your output should match the following:
B123
B177
B179
 
