namespace CalculatorCLI;

using System.CommandLine;

public static class Calculator
{
    public static int Main(string[] args)
    {
        var rootCommand = new RootCommand("Basic CLI Calculator");
        
        rootCommand.AddCommand(CommandFactories.CreateOperationCommand("add", HelperMethods.Add));
        rootCommand.AddCommand(CommandFactories.CreateOperationCommand("subtract", HelperMethods.Subtract));
        rootCommand.AddCommand(CommandFactories.CreateOperationCommand("multiply", HelperMethods.Multiply));
        rootCommand.AddCommand(CommandFactories.CreateOperationCommand("divide", HelperMethods.Divide));
        rootCommand.AddCommand(CommandFactories.CreateOperationCommand("even", HelperMethods.Even, "Add only even numbers"));
        rootCommand.AddCommand(CommandFactories.CreateOperationCommand("odd", HelperMethods.Odd, "Add only odd numbers"));
        rootCommand.AddCommand(CommandFactories.CreatePowerCommand());
        rootCommand.AddCommand(CommandFactories.CreateSqrtCommand());

        return rootCommand.InvokeAsync(args).Result;
    }
}
