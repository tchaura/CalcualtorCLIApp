namespace CalculatorCLITests;

using FluentAssertions;
using Xunit;

public class HelperMethodsTests
{
    [Theory]
    [InlineData(new double[] { 1, 2, 3 }, 6)]
    [InlineData(new double[] { 5, 5 }, 10)]
    public void Add_ShouldReturnCorrectSum(double[] numbers, double expected)
    {
        var result = CalculatorCLI.HelperMethods.Add(numbers);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(new double[] { 5, 2 }, 3)]
    [InlineData(new double[] { 10, 5, 2 }, 3)]
    public void Subtract_ShouldReturnCorrectResult(double[] numbers, double expected)
    {
        var result = CalculatorCLI.HelperMethods.Subtract(numbers);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(new double[] { 2, 3 }, 6)]
    [InlineData(new double[] { 4, 2.5 }, 10)]
    public void Multiply_ShouldReturnCorrectResult(double[] numbers, double expected)
    {
        var result = CalculatorCLI.HelperMethods.Multiply(numbers);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(new double[] { 10, 2 }, 5)]
    [InlineData(new double[] { 20, 5, 2 }, 2)]
    public void Divide_ShouldReturnCorrectResult(double[] numbers, double expected)
    {
        var result = CalculatorCLI.HelperMethods.Divide(numbers);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(new double[] { 2, 4, 6 }, 12)]
    [InlineData(new double[] { 3, 6, 9 }, 6)]
    public void Even_ShouldReturnCorrectSum(double[] numbers, double expected)
    {
        var result = CalculatorCLI.HelperMethods.Even(numbers);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(new double[] { 1, 3, 5 }, 9)]
    [InlineData(new double[] { 2, 4, 7 }, 7)]
    public void Odd_ShouldReturnCorrectSum(double[] numbers, double expected)
    {
        var result = CalculatorCLI.HelperMethods.Odd(numbers);
        result.Should().Be(expected);
    }
}