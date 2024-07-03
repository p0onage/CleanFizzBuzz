using CleanFizzBuzz.NumberParsers;
using NUnit.Framework;
using Shouldly;

namespace CleanFizzBuzzTests.NumberParsers;

public class FizzBuzzNumberParserTests
{
    [Test]
    public void Fizz_Number_Should_Be_Divisible_By_3()
    {
        // Arrange
        var numberParser = new BuzzNumberParser();
        
        // Act
        var result = numberParser.Parse(3);
        
        // Assert
        result.ShouldBe("Fizz");
    }
    
    [Test]
    public void Fizz_Number_Should_Not_Be_Divisible_By_2()
    {
        // Arrange
        var numberParser = new BuzzNumberParser();
        
        // Act
        var result = numberParser.Parse(2);
        
        // Assert
        result.ShouldBe("2");
    }

}