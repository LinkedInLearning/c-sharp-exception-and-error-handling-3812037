// Exercise file for C# Exception and Error Handling by Joe Marini
// Basic exceptions

try {
    int[] nums = {0,1,2,3,4,5,6,7,8,9};

    // Dividing by zero causes an exception
    Console.WriteLine($"Result: {IntDivider(nums[4],nums[1])}");

    // Indexing an array out of bounds is also an exception
    Console.WriteLine($"{nums[15]}");
}
catch (Exception e) {
    Console.WriteLine($"{e.Message}");
}

// A funtion that divides two integers
int IntDivider(int a, int b) {
    return a / b;
}
