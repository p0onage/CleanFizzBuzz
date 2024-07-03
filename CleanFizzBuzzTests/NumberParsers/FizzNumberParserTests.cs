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
        var numberParser = new FizzBuzzNumberParser();
        
        // Act
        var result = numberParser.Parse(number);
        
        // Assert
        result.ShouldBe("FizzBuzz");
    }
    
    [TestCase(16)]
    [TestCase(17)]
    [TestCase(1)]
    public void Number_Should_Not_Be_Divisible_By_5_and_3(int number)
    {
        // Arrange
        var numberParser = new FizzBuzzNumberParser();
        
        // Act
        var result = numberParser.Parse(number);
        
        // Assert
        result.ShouldBe(number.ToString());
    }

}