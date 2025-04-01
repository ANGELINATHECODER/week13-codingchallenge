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
 
----------------------------------------------------------------------------------------------------------------------------------------

You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.

Review the business rules for this challenge

Rule 1: Your code should only display one message.

The message that your code displays will depend on the other five rules. For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.

Rule 2: If the user's subscription will expire in 10 days or less, display the message:
Output: Your subscription will expire soon. Renew now!

Rule 3: If the user's subscription will expire in five days or less, display the messages:
Output: Your subscription expires in _ days.Renew now and save 10%!

Note

Be sure to substitute the value stored in the variable daysUntilExpiration for _ in your message.

Rule 4: If the user's subscription will expire in one day, display the messages:
Output: Your subscription expires within a day! Renew now and save 20%!

Rule 5: If the user's subscription has expired, display the message:
Output : Your subscription has expired.

Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.

To create the initial code for this challenge, enter the following code:
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here


Implement your solution code using if statements

Your solution must use two separate if statements to implement the business rules.

    Create an if statement that displays a message about when the subscription will expire.

    Tip:    Branch or nest three checks in this first if statement.

    Create a separate if statement that displays a discount offer.

    The business rules indicate when a discount should be offered.
