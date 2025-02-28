/// <summary>
/// Exception class that is thrown when an invalid sequence is generated.
/// </summary>
public class InvalidSequenceException : Exception
{
    public InvalidSequenceException(string message) : base(message) { }
}