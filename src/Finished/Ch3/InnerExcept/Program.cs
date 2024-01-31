// Exercise file for C# Exception and Error Handling by Joe Marini
// Inner exceptions

// Exercise file for C# Exception and Error Handling by Joe Marini
// Basic exceptions

try {
    int[] nums = {0,1,2,3,4,5,6,7,8,9};

    // Dividing by zero causes an exception
    Console.WriteLine($"Result: {IntDivider(nums[4],nums[0])}");
}
finally {
    Console.WriteLine("Program ended");
}

// A funtion that divides two integers
int IntDivider(int a, int b) {
    try {
        return a / b;
    }
    catch (DivideByZeroException e) {
        try {
            LogException(e);
        }
        catch (FileNotFoundException fnf) {
            Console.WriteLine($"File Not Found: {fnf}");
            if (fnf.InnerException != null) {
                Console.WriteLine($"InnerException: {fnf.InnerException}");
            }
        }
    }
    return 0;
}

void LogException(Exception e) {
    try {
        var logfile = File.Open("Exceptions.txt", FileMode.Open);
    }
    catch (FileNotFoundException fnf) {
        Console.WriteLine("Log file doesn't exist!");
        throw new FileNotFoundException("Exceptions.txt is missing!", e);
    }
}