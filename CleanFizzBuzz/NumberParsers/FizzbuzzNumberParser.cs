namespace CleanFizzBuzz.NumberParsers;

public class FizzBuzzNumberParser : INumberParser
{
    public int Divisor => 15;
    public string Word => "FizzBuzz";
    
    public string Parse(int number)
    {
        throw new NotImplementedException();
    }
}