// Exercise file for C# Exception and Error Handling by Joe Marini
// Programming Challenge - convert user input into numbers

bool Continue = true;

while (Continue) {
    Console.WriteLine("Enter the first integer number: ");
    string? str = Console.ReadLine();
    Console.WriteLine("Enter the second integer number: ");
    string? str2 = Console.ReadLine();

    Console.WriteLine("Enter the operation: (a)dd, (s)ubtract, (m)ultiply, (d)ivide or 'exit' to quit: ");
    string? op = Console.ReadLine();
    op = op?.ToLower();
    if (op == "exit") {
        break; // exit the loop at this point and terminate the program
    }

    // Challenge: Convert the string to a number and perform the operation

}
