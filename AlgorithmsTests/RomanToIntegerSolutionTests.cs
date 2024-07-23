using Algorithms.Roman_to_Integer___13;
using FluentAssertions;

namespace AlgoritmsTests;

public class RomanToIntegerSolutionTests
{
    [Fact]
    public void Test_case_1()
    {
        // Arrange
        string input = "III";
        RomanToIntegerSolution sut = new RomanToIntegerSolution();
        
        // Act
        int result = sut.RomanToInt(input);
        
        // Assert
        result.Should().Be(3);
    }
    
    [Fact]
    public void Test_case_2()
    {
        // Arrange
        string input = "LVIII";
        RomanToIntegerSolution sut = new RomanToIntegerSolution();
        
        // Act
        int result = sut.RomanToInt(input);
        
        // Assert
        result.Should().Be(58);
    }
    
    [Fact]
    public void Test_case_3()
    {
        // Arrange
        string input = "MCMXCIV";
        RomanToIntegerSolution sut = new RomanToIntegerSolution();
        
        // Act
        int result = sut.RomanToInt(input);
        
        // Assert
        result.Should().Be(1994);
    }
}