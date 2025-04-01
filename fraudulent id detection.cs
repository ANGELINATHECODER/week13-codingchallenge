using System;

class Program
{
    static void Main()
    {
        // Declare and initialize the array with order IDs
        string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        // Loop through each order ID
        foreach (string order in orderIDs)
        {
            // Check if the order ID starts with "B"
            if (order.StartsWith("B"))
            {
                // Print the fraudulent order ID
                Console.WriteLine(order);
            }
        }
    }
}
