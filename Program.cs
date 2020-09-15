using System;
using System.Text;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;

            switch(argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;

                // Add additional exponential power function as per step 4:
                case "exponential":
                case "^":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }
            return result;

            // Add StringBuilder function as per step 2:
            StringBuilder myResult = new StringBuilder(argFirstNumber+argOperation+argSecondNumber+"="+result);
        }
    }
}
