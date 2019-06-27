using NUnit.Framework;

namespace SimpleCalculator.Test.Unit
{
    public class InputConverterTest
    {
        private InputConverter _inputConverter = new InputConverter();

        [Test]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [Test]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            Assert.That(() => _inputConverter.ConvertInputToNumeric(inputNumber), Throws.ArgumentException);
        }
    }
}