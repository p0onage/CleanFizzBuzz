using CleanFizzBuzz.NumberParsers;

namespace CleanFizzBuzz.Service;

public class NumberGenerator
{
    public List<string> GetFizzBuzzNumbers(int start, int end)
    {
        var fizzBuzzResults = new List<string>();
        var inputRange = Enumerable.Range(start, end).ToList();
        var numberParsers = Parsers();
            
        inputRange.ForEach(n =>
        {
            var validParser = numberParsers.First(p => n % p.Divisor == 0);
            fizzBuzzResults.Add(validParser.Parse(n));
        });
            
        return fizzBuzzResults;
    }
    
    private List<INumberParser> Parsers()
    {
            var interfaceType = typeof(INumberParser);
            
            return AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(x => x.GetTypes())
                    .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                    .Select(x => Activator.CreateInstance(x))
                    .Cast<INumberParser>()
                    .OrderByDescending(p => p.Divisor)
                    .ToList();
    }
}