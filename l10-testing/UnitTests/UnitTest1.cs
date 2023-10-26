//CASE 1: VALID INPUT
using Xunit;
using ExampleApp;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void CombineArrayString_GivenValidInput_ReturnsCombinedString()
    {
        // Arrange
        string[] testArray = { "This", "is", "a", "test" };
        Example testClass = new Example();


        // Act
        var result = testClass.combineArrayString(testArray);


        // Assert
        Assert.Equal("This is a test", result);

    }
}

