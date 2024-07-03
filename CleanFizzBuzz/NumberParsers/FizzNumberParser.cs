namespace CleanFizzBuzz.NumberParsers;

public class FizzNumberParser : INumberParser
{
    public int Divisor => 3;
    public string Word => "Fizz";
    
    public string Parse(int number)
    {
        throw new NotImplementedException();
    }
}