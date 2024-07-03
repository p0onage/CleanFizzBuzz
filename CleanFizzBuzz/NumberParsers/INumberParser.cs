namespace CleanFizzBuzz.NumberParsers;

public interface INumberParser
{
    public int Divisor { get; }
    public string Word { get; } 
    public string Parse(int number);
}