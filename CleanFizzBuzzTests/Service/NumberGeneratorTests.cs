using CleanFizzBuzz.Service;
using NUnit.Framework;
using Shouldly;

namespace CleanFizzBuzzTests.Service;

public class NumberGeneratorTests
{
 
    [Test]
    public void Should_Get_Number_Count_Of_100()
    {
        // Arrange
        var numberGenerator = new NumberGenerator();
        
        // Act
        var numbers = numberGenerator.GetFizzBuzzNumbers(1, 100);
        
        // Assert
        numbers.Count().ShouldBe(100);
    }
}