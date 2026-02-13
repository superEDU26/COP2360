using System;

public class Stock
{
    // Automatic properties
    public decimal CurrentPrice { get; set; }
    public decimal SharesOwned { get; set; }

    // Read-only calculated property
    public decimal Worth
    {
        get { return CurrentPrice * SharesOwned; }
    }
}

public class Program
{
    public static void Main()
    {
        // Creating an instance of the class
        Stock myStock = new Stock();

        // Setting property values
        myStock.CurrentPrice = 50m;
        myStock.SharesOwned = 100m;

        // Displaying result
        Console.WriteLine("Stock worth: " + myStock.Worth);
    }
}
