namespace CleanFizzBuzz.NumberParsers;

public class FizzNumberParser : INumberParser
{
    public int Divisor => 3;
    public string Word => "Fizz";
    
    public string Parse(int number)
    {
        if (number % Divisor == 0)
            return Word;

        throw new Exception($"This number is not a {Word} number.");
    }
}