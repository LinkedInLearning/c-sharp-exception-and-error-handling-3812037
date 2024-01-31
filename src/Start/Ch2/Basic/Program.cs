// Exercise file for C# Exception and Error Handling by Joe Marini
// Basic exceptions

int[] nums = {0,1,2,3,4,5,6,7,8,9};

// Dividing by zero causes an exception
Console.WriteLine($"Result: {IntDivider(nums[5],nums[2])}");

// Indexing an array out of bounds is also an exception
Console.WriteLine($"{nums[8]}");

// A funtion that divides two integers
int IntDivider(int a, int b) {
    return a / b;
}
