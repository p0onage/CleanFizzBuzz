namespace CleanFizzBuzz.NumberParsers;

public class NumberParser : INumberParser
{
    public int Divisor => -1;
    public string Word { get; }

    public string Parse(int number)
    {
        throw new NotImplementedException();
    }
}