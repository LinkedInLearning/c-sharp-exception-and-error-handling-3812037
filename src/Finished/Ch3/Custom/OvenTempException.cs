// Exercise file for C# Exception and Error Handling by Joe Marini
// Creating custome exception types

public class OvenTempException : Exception {
    public int OvenTemp { init; get; }

    public OvenTempException() : base() {
        OvenTemp = 0;
    }
    public OvenTempException(string Message) : base(Message) {
        OvenTemp = 0;
    }
    public OvenTempException(string Message, Exception InnerException) : base(Message, InnerException) {
        OvenTemp = 0;
    }
    public OvenTempException(int Value) : base ($"The oven cannot be set to {Value}") {
        OvenTemp = Value;
    }
}
