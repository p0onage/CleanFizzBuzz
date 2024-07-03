namespace CleanFizzBuzz.NumberParsers;

public class BuzzNumberParser : INumberParser
{
    public int Divisor => 5;
    public string Word => "Buzz";
    
    public string Parse(int number)
    {
        throw new NotImplementedException();
    }
}