namespace CalculatorCLI;

public static class HelperMethods
{
        
    public static double Add(double[] numbers) => numbers.Sum();
    public static double Subtract(double[] numbers) => numbers.Aggregate((a, b) => a - b);
    public static double Multiply(double[] numbers) => numbers.Aggregate((a, b) => a * b);
    public static double Divide(double[] numbers)
    {
        if (numbers.Skip(1).Any(n => n == 0))
            throw new ArgumentException("Division by zero is not allowed.");
        return numbers.Aggregate((a, b) => a / b);
    }

    public static double Even(double[] numbers) => numbers.Where(n => n % 2 == 0).Sum();
    public static double Odd(double[] numbers) => numbers.Where(n => n % 2 != 0).Sum();
}