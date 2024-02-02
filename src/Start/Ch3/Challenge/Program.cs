// Exercise file for C# Exception and Error Handling by Joe Marini
// Challenge for Ch3: The Coin Counter

string[] TestCoins = {
    "Nickel",
    "Penny",
    "Dime",
    "Quarter",
    "Washer",
    "Spacer",
    "HalfDollar",
    "Dollar",
    "Dime",
    "Penny",
    "Washer",
    "Token",
    "Quarter",
    "Medallion",
    "Nickel",
    "Nickel",
    "Dollar"
};

// The code that your solution will be called with
CoinCounter Counter = new();
foreach (string Coin in TestCoins)
{
    Counter.CountCoin(Coin);
}
Console.WriteLine($"Total amount counted is: {Counter.Total:C}");
Counter.ListBadCoins();

// YOUR SOLUTION CODE GOES HERE:
// =============================
public class CoinCounter
{
    private decimal _totalAmount = 0;

    public CoinCounter() { }

    public void CountCoin(string CoinType)
    {
    }

    public void ListBadCoins()
    {
    }

    public decimal Total
    {
        get => _totalAmount;
    }
}

public class CoinException : Exception
{
}
