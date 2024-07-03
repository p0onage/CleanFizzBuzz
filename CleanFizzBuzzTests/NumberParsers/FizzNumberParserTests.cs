using CleanFizzBuzz.NumberParsers;
using NUnit.Framework;
using Shouldly;

namespace CleanFizzBuzzTests.NumberParsers;

public class FizzNumberParserTests
{
    [TestCase(15)]
    [TestCase(30)]
    public void Number_Should_Be_Divisible_By_5_and_3(int number)
    {
 
        // Arrange
        var numberParser = new FizzNumberParser();
        
        // Act
        var result = numberParser.Parse(number);
        
        // Assert
        result.ShouldBe("Fizz");
    }
    
    [TestCase(16)]
    [TestCase(17)]
    [TestCase(1)]
    public void Number_Should_Not_Be_Divisible_By_5_and_3(int number)
    {
        // Arrange
        var numberParser = new FizzNumberParser();
        
        // Act & Assert
        Should.Throw<Exception>(() => numberParser.Parse(number))
            .Message.ShouldBe($"This number is not a Fizz number.");
    }

}