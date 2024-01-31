// Exercise file for C# Exception and Error Handling by Joe Marini
// Creating custome exception types

try {
    var Oven = new MyOven();

    Oven.SetOvenTemp(200);
    Console.WriteLine($"Oven temp set to {Oven.GetOvenTemp()}");

    Oven.SetOvenTemp(600);
    Console.WriteLine($"Oven temp set to {Oven.GetOvenTemp()}");
}
catch (OvenTempException e) {
    Console.WriteLine($"Exception: {e.Message}");
}
finally {
    Console.WriteLine("Done");
}

public class MyOven
{
    private int OvenTemp;

    public void SetOvenTemp(int TemperatureF)
    {
        // Make sure that the argument is between 100 and 500
        if (TemperatureF < 100 || TemperatureF > 500)
        {
            throw new OvenTempException(TemperatureF);
        }
        OvenTemp = TemperatureF;
    }

    public int GetOvenTemp()
    {
        return OvenTemp;
    }
}