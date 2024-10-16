namespace CalculatorCLITests;

using ApprovalTests;
using ApprovalTests.Reporters;

[UseReporter(typeof(DiffReporter))]
public class ConsoleOutputTests
{
    [Fact]
    public void TestAdditionCommand()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var args = new[] { "add", "1", "2", "-f" };
        CalculatorCLI.Calculator.Main(args);

        var output = writer.ToString();
        Approvals.Verify(output);
    }

    [Fact]
    public void TestDivisionByZero()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var args = new[] { "divide", "4", "0" };
        CalculatorCLI.Calculator.Main(args);

        var output = writer.ToString();
        Approvals.Verify(output);
    }

    [Fact]
    public void TestSubtractionCommand()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var args = new[] { "subtract", "5", "3" };
        CalculatorCLI.Calculator.Main(args);

        var output = writer.ToString();
        Approvals.Verify(output);
    }

    [Fact]
    public void TestMultiplicationCommand()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var args = new[] { "multiply", "2", "3" };
        CalculatorCLI.Calculator.Main(args);

        var output = writer.ToString();
        Approvals.Verify(output);
    }

    [Fact]
    public void TestPowerCommand()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var args = new[] { "power", "2", "3" };
        CalculatorCLI.Calculator.Main(args);

        var output = writer.ToString();
        Approvals.Verify(output);
    }

    [Fact]
    public void TestSqrtCommand()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var args = new[] { "sqrt", "9" };
        CalculatorCLI.Calculator.Main(args);

        var output = writer.ToString();
        Approvals.Verify(output);
    }

    [Fact]
    public void TestEvenCommand()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var args = new[] { "even", "1", "2", "3", "4" };
        CalculatorCLI.Calculator.Main(args);

        var output = writer.ToString();
        Approvals.Verify(output);
    }

    [Fact]
    public void TestOddCommand()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var args = new[] { "odd", "1", "2", "3", "4" };
        CalculatorCLI.Calculator.Main(args);

        var output = writer.ToString();
        Approvals.Verify(output);
    }
}