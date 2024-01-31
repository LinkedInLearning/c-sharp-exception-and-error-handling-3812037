// Exercise file for C# Exception and Error Handling by Joe Marini
// Programming Challenge - convert user input into numbers

bool Continue = true;
int Op1, Op2;
int result;

while (Continue) {
    Console.WriteLine("Enter the first integer number: ");
    string str = Console.ReadLine();
    Console.WriteLine("Enter the second integer number: ");
    string str2 = Console.ReadLine();

    Console.WriteLine("Enter the operation: (a)dd, (s)ubtract, (m)ultiply, (d)ivide or 'exit' to quit: ");
    string op = Console.ReadLine();
    op = op.ToLower();
    if (op == "exit") {
        break; // exit the loop at this point and terminate the program
    }

    // Challenge: Convert the string to a number and perform the operation
    try {
        Op1 = int.Parse(str);
        Op2 = int.Parse(str2);

        switch (op) {
            case "a":
                result = Op1 + Op2;
                break;
            case "s":
                result = Op1 - Op2;
                break;
            case "m":
                result = Op1 * Op2;
                break;
            case "d":
                result = Op1 / Op2;
                break;
            default:
                throw new ArgumentException($"'{op}' is not a valid operation", "op");
                break;
        }
        Console.WriteLine($"Result is: {result}");
    }
    catch (FormatException e) {
        Console.WriteLine($"{e.Message}");
    }
    catch (DivideByZeroException e) {
        Console.WriteLine($"{e.Message}");
    }
    catch (ArgumentException e) {
        Console.WriteLine($"{e.Message}");
    }
}
