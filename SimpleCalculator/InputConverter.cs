using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string input)
        {
            return double.TryParse(input, out double convertedNumber) 
                ? convertedNumber : throw new ArgumentException("Expected a numeric value.");
        }
    }
}