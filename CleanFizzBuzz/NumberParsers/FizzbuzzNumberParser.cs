namespace CleanFizzBuzz.NumberParsers;

public class FizzBuzzNumberParser : INumberParser
{
    public int Divisor => 15;
    public string Word => "FizzBuzz";
    
    public string Parse(int number)
    {
        if (number % Divisor == 0)
            return Word;

        throw new Exception($"This number is not a {Word} number.");
    }
}