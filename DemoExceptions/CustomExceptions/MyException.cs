namespace DemoExceptions.CustomExceptions;

public class MyException : Exception
{
    public MyException(string message) : base(message) {}
}