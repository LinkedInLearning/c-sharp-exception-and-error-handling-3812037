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
    private List<string> _badCoins = new();
    private decimal _totalAmount = 0;

    public CoinCounter() { }

    public void CountCoin(string CoinType)
    {
        try
        {
            _totalAmount += CoinValue(CoinType);
        }
        catch (CoinException ce)
        {
            _badCoins.Add(ce.ObjType);
        }
    }

    private decimal CoinValue(string CoinType)
    {
        switch (CoinType)
        {
            case "Penny":
                return 0.01m;
            case "Nickel":
                return 0.05m;
            case "Dime":
                return 0.1m;
            case "Quarter":
                return 0.25m;
            case "HalfDollar":
                return 0.5m;
            case "Dollar":
                return 1.0m;
            default:
                throw new CoinException("Bad coin type", CoinType);
        }
    }

    public void ListBadCoins()
    {
        Console.WriteLine($"{_badCoins.Count} bad coins counted");
        foreach (string s in _badCoins)
        {
            Console.WriteLine($"{s}");
        }
    }

    public decimal Total
    {
        get => _totalAmount;
    }
}

public class CoinException : Exception
{
    public string ObjType;

    // Define the 3 constructors needed for best practices
    public CoinException() : base() { ObjType = ""; }
    public CoinException(string Message) : base(Message) { ObjType = ""; }
    public CoinException(string Message, Exception inner) : base(Message, inner)
    {
        ObjType = "";
    }

    public CoinException(string CoinType, string Message) : base(Message)
    {
        ObjType = CoinType;
    }
}
