namespace CleanFizzBuzz.NumberParsers;

public class BuzzNumberParser : INumberParser
{
    public int Divisor => 5;
    public string Word => "Buzz";
    
    public string Parse(int number)
    {
        if (number % Divisor == 0)
            return Word;

        throw new Exception($"This number is not a {Word} number.");
    }
}