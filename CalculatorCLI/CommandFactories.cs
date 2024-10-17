namespace CalculatorCLI;

using System.CommandLine;
using System.CommandLine.NamingConventionBinder;

public static class CommandFactories
{
    public static Command CreateOperationCommand(string name, Func<double[], double> operation, string description = "")
    {
        var command = new Command(name,!string.IsNullOrEmpty(description) ? description : $"{name} numbers")
        {
            new Argument<string[]>("numbers", "Numbers to operate on"),
            new Option<bool>(new[] { "-f", "--float" }, "Use floating-point numbers")
        };
        command.Handler = CommandHandler.Create<string[], bool>((numbers, @float) =>
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine(Messages.NoNumbersGivenError);
                return;
            }
            
            double[] parsedNumbers;
            try
            {
                parsedNumbers = numbers.Select(double.Parse).ToArray();
            }
            catch
            {
                Console.WriteLine(Messages.InvalidNumbersError);
                return;
            }
            
            if (!@float && Array.Exists(parsedNumbers, number => number % 1 != 0))
            {
                Console.WriteLine(Messages.CannotWorkWithFloatsError);
                return;
            }

            try
            {
                var result = operation(parsedNumbers);
                Console.WriteLine(Messages.ResultInfo, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Messages.CalculationError, ex.Message);
            }
        });

        return command;
    }

    public static Command CreatePowerCommand()
    {
        var command = new Command("power", "Calculate power")
        {
            new Argument<double[]>("baseAndExponent", "Base and exponent (e.g., 2 3 for 2^3)")
        };
        command.Handler = CommandHandler.Create<double[]>((baseAndExponent) =>
        {
            if (baseAndExponent.Length != 2)
            {
                Console.WriteLine(Messages.BaseExponentRequiredError);
                return;
            }
            try
            {
                var result = Math.Pow(baseAndExponent[0], baseAndExponent[1]);
                Console.WriteLine(string.Format(Messages.ResultInfo, result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(Messages.CalculationError, ex.Message));
            }
        });

        return command;
    }

    public static Command CreateSqrtCommand()
    {
        var command = new Command("sqrt", "Calculate square root")
        {
            new Argument<double>("number", "Number to find square root")
        };
        command.Handler = CommandHandler.Create<double>((number) =>
        {
            if (number < 0)
            {
                Console.WriteLine(Messages.NegativeSqrtError);
                return;
            }
            try
            {
                var result = Math.Sqrt(number);
                Console.WriteLine(string.Format(Messages.ResultInfo, result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(Messages.CalculationError, ex.Message));
            }
        });

        return command;
    }
}
