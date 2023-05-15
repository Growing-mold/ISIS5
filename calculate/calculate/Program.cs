using System;

namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char op;
            bool validInput = false;
            do
            {
                Console.WriteLine("Enter the first number:");
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput);
            validInput = false;
            do
            {
                Console.WriteLine("Enter the second number:");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput);
            validInput = false;
            do
            {
                Console.WriteLine("Enter the operator (+, -, *, /, ^):");
                if (char.TryParse(Console.ReadLine(), out op))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid operator.");
                }
            } while (!validInput);

            double result = Program.Calculate(num1, num2, op);

            Console.WriteLine($"Result: {result}");
        }

        public static double Calculate(double num1, double num2, char op)
        {
            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                case '^':
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            return result;
        }
    }
}

