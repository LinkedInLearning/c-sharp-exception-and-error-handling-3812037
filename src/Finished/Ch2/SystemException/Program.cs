// Exercise file for C# Exception and Error Handling by Joe Marini
// Using the System.Exception class

try {
    int[] nums = {0,1,2,3,4,5,6,7,8,9};

    // Indexing an array out of bounds is an exception
    Console.WriteLine($"{nums[15]}");
}
catch (Exception e) {
    //Console.WriteLine($"{e}");
    
    // Get the actual Type of the exception
    Console.WriteLine($"Type: {e.GetType()}");
    // Retrieve the message string that the exception was created with
    Console.WriteLine($"Message: {e.Message}");
    // The HelpLink field is optional and supplies a link to get more information
    Console.WriteLine($"HelpLink: {e.HelpLink}");
    // Source is the application or object where the exception occurred
    Console.WriteLine($"Source: {e.Source}");
    // TargetSite is the name of the method that threw the exception
    Console.WriteLine($"TargetSite: {e.TargetSite}");
    // The StackTrace contains the stack calls leading up to the exception
    Console.WriteLine($"Stack: {e.StackTrace}");
}
