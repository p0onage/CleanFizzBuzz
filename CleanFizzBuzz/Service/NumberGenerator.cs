namespace CleanFizzBuzz.Service;

public class NumberGenerator
{
    public IEnumerable<string> GetFizzBuzzNumbers(int start, int end)
    {
        var inputRange = Enumerable.Range(start, end).ToList()
            
            
        return inputRange.Select(x => x.ToString());
    }
}