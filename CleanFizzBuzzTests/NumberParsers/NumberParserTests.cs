using CleanFizzBuzz.NumberParsers;
using NUnit.Framework;
using Shouldly;

namespace CleanFizzBuzzTests.NumberParsers;

public class NumberParserTests
{
    [Test]
    public void Parser_Should_Return_5()
    {
        // Arrange
        var numberParser = new NumberParser();
        
        // Act
        var result = numberParser.Parse(5);
        
        // Assert
        result.ShouldBe("5");
    }
}