using CleanFizzBuzz.NumberParsers;
using NUnit.Framework;
using Shouldly;

namespace CleanFizzBuzzTests.NumberParsers;

public class BuzzNumberParserTests
{
    [Test]
    public void Buzz_Number_Should_Be_Divisible_By_5()
    {
        // Arrange
        var numberParser = new BuzzNumberParser();
        
        // Act
        var result = numberParser.Parse(5);
        
        // Assert
        result.ShouldBe("Buzz");
    }
    
    [Test]
    public void Buzz_Number_Should_Not_Throw_Exception_If_Not_Divisible_By_3()
    {
        // Arrange
        var numberParser = new BuzzNumberParser();
        
        // Act & Assert
        Should.Throw<Exception>(() => numberParser.Parse(3))
            .Message.ShouldBe($"This number is not a Buzz number.");
    }

}