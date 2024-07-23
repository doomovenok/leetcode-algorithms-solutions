using Algorithms.Two_Sum___1;
using FluentAssertions;

namespace AlgoritmsTests;

public class TwoSumSolutionTests
{
    [Fact]
    public void Test_case_1()
    {
        // Arrange
        int[] nums = new[] { 2, 7, 11, 15 };
        int target = 9;
        TwoSumSolution sut = new TwoSumSolution();
        
        // Act
        int[] result = sut.TwoSum(nums, target);

        // Assert
        result.Should().BeEquivalentTo(new int[] { 0, 1 });
    }
    
    [Fact]
    public void Test_case_2()
    {
        // Arrange
        int[] nums = new[] { 3, 2, 4 };
        int target = 6;
        TwoSumSolution sut = new TwoSumSolution();
        
        // Act
        int[] result = sut.TwoSum(nums, target);

        // Assert
        result.Should().BeEquivalentTo(new int[] { 1, 2 });
    }
    
    [Fact]
    public void Test_case_3()
    {
        // Arrange
        int[] nums = new[] { 3, 3 };
        int target = 6;
        TwoSumSolution sut = new TwoSumSolution();
        
        // Act
        int[] result = sut.TwoSum(nums, target);

        // Assert
        result.Should().BeEquivalentTo(new int[] { 0, 1 });
    }
}