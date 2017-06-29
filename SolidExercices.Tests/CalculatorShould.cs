using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }
        public void CalculateADivide()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3/2");
            Check.That(result).IsEqualTo(1.5);
        }
        public void CalculateAMultiply()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2x3");
            Check.That(result).IsEqualTo(6);
        }
        public void CalculateASubstract()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3-1,5");
            Check.That(result).IsEqualTo(1.5);
        }
    }
}
