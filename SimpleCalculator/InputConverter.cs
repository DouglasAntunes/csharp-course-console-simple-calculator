using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string input)
        {
            if (!double.TryParse(input, out double convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value.");
            }
            return convertedNumber;
        }
    }
}