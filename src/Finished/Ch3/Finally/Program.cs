// Exercise file for C# Exception and Error Handling by Joe Marini
// Using the "finally" keyword to ensure code always executes

try {
    int[] nums = {0,1,2,3,4,5,6,7,8,9};

    // Dividing by zero causes an exception
    Console.WriteLine($"Result: {IntDivider(10,0)}");

    // Indexing an array out of bounds is also an exception
    Console.WriteLine($"{nums[15]}");
}
catch (DivideByZeroException e) {
    Console.WriteLine($"Divide by zero!");
}
catch (IndexOutOfRangeException e) {
    Console.WriteLine($"Index out of range!");
}
finally {
    // Code in the finally block always runs regardless of what happens
    Console.WriteLine("This code always runs!");
}

// A funtion that divides two integers
int IntDivider(int a, int b) {
    return a / b;
}
