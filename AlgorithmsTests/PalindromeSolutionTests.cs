using Algorithms.Palindrome_Number___9;
using FluentAssertions;

namespace AlgorithmsTests;

public class PalindromeSolutionTests
{
    [Fact]
    public void Test_case_1()
    {
        // Arrange
        int num = 121;
        PalindromeNumberSolution sut = new PalindromeNumberSolution();
        
        // Act
        bool result = sut.IsPalindrome(num);
        
        // Assert
        result.Should().BeTrue();
    }
    
    [Fact]
    public void Test_case_2()
    {
        // Arrange
        int num = -121;
        PalindromeNumberSolution sut = new PalindromeNumberSolution();
        
        // Act
        bool result = sut.IsPalindrome(num);
        
        // Assert
        result.Should().BeFalse();
    }
    
    [Fact]
    public void Test_case_3()
    {
        // Arrange
        int num = 10;
        PalindromeNumberSolution sut = new PalindromeNumberSolution();
        
        // Act
        bool result = sut.IsPalindrome(num);
        
        // Assert
        result.Should().BeFalse();
    }
}