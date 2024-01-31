// Exercise file for C# Exception and Error Handling by Joe Marini
// Creating custome exception types

public class OvenTempException : Exception {
    public int OvenTemp { init; get; }

    public OvenTempException() : base() {
        OvenTemp = 0;
    }
    public OvenTempException(int value, string Message) : base(Message) {
        OvenTemp = value;
    }
    public OvenTempException(int value, string Message, Exception InnerException) : base(Message, InnerException) {
        OvenTemp = value;
    }
    public OvenTempException(int value) : base ($"The oven cannot be set to {value}") {
        OvenTemp = value;
    }
}
