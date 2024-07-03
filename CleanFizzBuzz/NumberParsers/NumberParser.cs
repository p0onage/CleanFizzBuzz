namespace CleanFizzBuzz.NumberParsers;

public class NumberParser : INumberParser
{
    public int Divisor => -1;
    public string Word { get; } = string.Empty;

    public string Parse(int number)
    {
        if (number % Divisor == 0)
            return number.ToString();

        throw new Exception($"Number is not divisible by {Divisor}.");
    }
}