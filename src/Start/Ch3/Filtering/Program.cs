// Exercise file for C# Exception and Error Handling by Joe Marini
// Using exception filtering

int[] nums = {0,1,2,3,4,5,6,7,8,9};

Console.WriteLine($"Value: {GetValue(nums, 5)}");

int? GetValue(int[] array, int index) {
    int? val = null;
    try {
        val = array[index];
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine($"Parameter 'index' cannot be greater than the array size: {index}");
    }
    return val;
}
