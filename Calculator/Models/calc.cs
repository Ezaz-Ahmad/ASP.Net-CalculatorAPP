using System;

namespace Calculator.Models
{
    public class calc
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        private string operationType;

        public double Result
        {
            get
            {
                switch (operationType?.ToLower())
                {
                    case "add":
                        return num1 + num2;
                    case "sub":
                        return num1 - num2;
                    case "mul":
                        return num1 * num2;
                    case "div":
                        return num2 != 0 ? num1 / num2 : double.NaN; // Use NaN to indicate division by zero
                    case "exp":
                        return Math.Pow(num1, num2);
                    case "sin":
                        return Math.Sin(num1); // Only uses num1
                    // can be added more cases for other operations like cos, tan, log, etc.
                    default:
                        return double.NaN; // Default case to handle unknown operations
                }
            }
        }

        public void SetOperation(string operation)
        {
            operationType = operation;
        }
    }
}
