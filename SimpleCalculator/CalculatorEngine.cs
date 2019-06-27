using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result;

            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }

            return result;
        }
    }
}