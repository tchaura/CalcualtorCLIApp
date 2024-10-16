# Calculator CLI

A basic calculator command-line interface (CLI) application that supports a variety of arithmetic operations.

## User Stories
- User can use all the basic arithmetic operations (addition, subtraction, multiplication, division) with multiple numbers.
- User can add floating numbers using the `-f` flag (and only integers without it).
- User can add even/odd numbers using the `even` or `odd` sub-command.
- User can use `--help` or `-h` flag to get all the available commands and flags.
- User can calculate the power of a number and the square root of a number.

## Usage

### Basic Arithmetic Operations

- Addition:
  calc add 1 2 3 -f


- Subtraction:
  calc subtract 10 4 2


- Multiplication:
  calc multiply 2 3 4 -f


Copy

- Division:
  calc divide 10 2


### Special Commands

- Even numbers addition:
  calc even 1 2 3 4


- Odd numbers addition:
  calc odd 1 2 3 4


- Calculate power:
  calc power 2 3


- Calculate square root:
  calc sqrt 9

### Help

Use the `--help` or `-h` flag to get all available commands and flags:
calc --help


## Error Handling

- Invalid numbers will produce an error message.
- Division by zero will produce an error message.
- Missing required arguments will produce an error message.

## Tests

All tests for app are in separate project `CalculatorCLITest` with use of:
- XUnit
- FluentAssertions
- ApprovalTests

## Installation

Make sure to install the necessary NuGet packages and run it in your terminal
