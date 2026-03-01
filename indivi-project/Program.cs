using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number (numerator):");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number (denominator/x):");
        string input2 = Console.ReadLine();

        // Pass both inputs to the logic method
        MainMain(input1, input2);
    }

    static void MainMain(params string[] args)
    {
        try
        {
            // Note: Parse arguments from array
        
            int num1 = int.Parse(args[0]);
            int x = int.Parse(args[1]);

            
            int result = Calc(num1, x);

            Console.WriteLine($"Successfully calculated: {num1} / {x} = {result}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Please provide at least two arguments");
        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a valid number!");
        }
        catch (DivideByZeroException)
        {
            
            Console.WriteLine("Error: x cannot be zero. Cannot divide by zero!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number provided is too large for an integer!");
        }
    }


    static int Calc(int a, int b)
    {
        return a / b;
    }
}
